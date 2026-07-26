using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace TareaConecta4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TableroConecta4 juego;
        private Ellipse[,] matrizFichasUI;
        private DispatcherTimer timer = new DispatcherTimer();

        private int tiempoRestante;
        private int limiteTiempo = 10;
        private int victoriasRojo = 0;
        private int victoriasAmarillo = 0;
        public MainWindow()
        {
            InitializeComponent();

            if (ChkTemporizador != null)
            {
                ChkTemporizador.Checked += ChkTemporizador_Changed;
                ChkTemporizador.Unchecked += ChkTemporizador_Changed;
            }
            InicializarJuegoUI();
            ConfigurarTimer();
        }

        private void InicializarJuegoUI()
        {
            juego = new TableroConecta4();
            matrizFichasUI = new Ellipse[TableroConecta4.Filas, TableroConecta4.Columnas];
            GridTablero.Children.Clear();
            GridTablero.RowDefinitions.Clear();
            GridTablero.ColumnDefinitions.Clear();

            for (int f = 0; f < TableroConecta4.Filas; f++)
                GridTablero.RowDefinitions.Add(new RowDefinition());

            for (int c = 0; c < TableroConecta4.Columnas; c++)
                GridTablero.ColumnDefinitions.Add(new ColumnDefinition());

            for (int f = 0; f < TableroConecta4.Filas; f++)
            {
                for (int c = 0; c < TableroConecta4.Columnas; c++)
                {
                    Border celdaContainer = new Border
                    {
                        Background = new SolidColorBrush(Color.FromRgb(29, 78, 216)),
                        Margin = new Thickness(2)
                    };

                    Ellipse ficha = new Ellipse
                    {
                        Fill = Brushes.White,
                        Margin = new Thickness(6),
                        Tag = c
                    };

                    ficha.MouseLeftButtonDown += Ficha_MouseLeftButtonDown;
                    ficha.MouseEnter += Ficha_MouseEnter;
                    ficha.MouseLeave += Ficha_MouseLeave;

                    matrizFichasUI[f, c] = ficha;
                    celdaContainer.Child = ficha;

                    Grid.SetRow(celdaContainer, f);
                    Grid.SetColumn(celdaContainer, c);
                    GridTablero.Children.Add(celdaContainer);
                }
            }

            ActualizarInterfaz();
        }

        private void ConfigurarTimer()
        {
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick -= Timer_Tick;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;
            if (LblTiempo != null)
                LblTiempo.Text = $"Tiempo restante: {tiempoRestante}s";

            if (tiempoRestante <= 0)
            {
                timer?.Stop();
                MessageBox.Show("¡Se agotó el tiempo! Cambio de turno automático.", "Tiempo Agotado", MessageBoxButton.OK, MessageBoxImage.Warning);
                juego?.CambiarTurno();
                ReiniciarTimer();
                ActualizarInterfaz();

                _ = EvaluarTurnoIA();
            }
        }

        private void ReiniciarTimer()
        {
            if (!this.IsInitialized)
                return;
            timer?.Stop();
            if (ChkTemporizador != null && ChkTemporizador.IsChecked == true)
            {
                tiempoRestante = limiteTiempo;
                if (LblTiempo != null)
                    LblTiempo.Text = $"Tiempo restante: {tiempoRestante}s";
                timer?.Start();
            }
            else
            {
                if (LblTiempo != null)
                    LblTiempo.Text = "Tiempo: Desactivado";
            }
        }

        private async void Ficha_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (juego.JuegoTerminado) return;

                if (juego.Modo == ModoJuego.HumanoVsIA && juego.TurnoActual == juego.JugadorIA) return;

                Ellipse fichaClick = sender as Ellipse;
                if (fichaClick == null) return;

                int columna = (int)fichaClick.Tag;
                int filaCaida = juego.SoltarFicha(columna);

                if (filaCaida == -1)
                {
                    MessageBox.Show("La columna está llena. Intenta en otra.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }

                LstHistorial.Items.Insert(0, $"{TxtJugador1.Text} jugó en Col. {columna + 1}");

                if (ProcesarFinDeJuego(filaCaida, columna)) return;

                juego.CambiarTurno();
                ActualizarInterfaz();
                ReiniciarTimer();
                await EvaluarTurnoIA();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error Inesperado", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async Task EvaluarTurnoIA()
        {
            if (juego.Modo == ModoJuego.HumanoVsIA && juego.TurnoActual == juego.JugadorIA && !juego.JuegoTerminado)
            {
                await Task.Delay(600);

                var (filaIA, colIA) = juego.ObtenerJugadaIA();
                if (filaIA != -1)
                {
                    LstHistorial.Items.Insert(0, $" Computadora jugó en Col. {colIA + 1}");

                    if (ProcesarFinDeJuego(filaIA, colIA)) return;

                    juego.CambiarTurno();
                    ActualizarInterfaz();
                    ReiniciarTimer();
                }
            }
        }

        private bool ProcesarFinDeJuego(int fila, int columna)
        {
            string nombreJugador = (juego.TurnoActual == Jugador.Rojo) ? TxtJugador1.Text : TxtJugador2.Text;

            if (juego.VerificarGanador(fila, columna))
            {
                timer?.Stop();
                ActualizarMatrizVisual();

                if (juego.TurnoActual == Jugador.Rojo) victoriasRojo++;
                else victoriasAmarillo++;

                ActualizarMarcador();
                MessageBox.Show($"¡Felicidades {nombreJugador}! Has ganado la partida.", "¡Victoria!", MessageBoxButton.OK, MessageBoxImage.Information);
                return true;
            }

            if (juego.EsEmpate())
            {
                timer?.Stop();
                ActualizarMatrizVisual();
                MessageBox.Show("¡La partida ha terminado en empate!", "Empate", MessageBoxButton.OK, MessageBoxImage.Information);
                return true;
            }

            return false;
        }

        private void ActualizarMatrizVisual()
        {
            for (int f = 0; f < TableroConecta4.Filas; f++)
            {
                for (int c = 0; c < TableroConecta4.Columnas; c++)
                {
                    Jugador estado = juego.ObtenerCelda(f, c);
                    switch (estado)
                    {
                        case Jugador.Rojo:
                            matrizFichasUI[f, c].Fill = new SolidColorBrush(Color.FromRgb(220, 38, 38));
                            break;
                        case Jugador.Amarillo:
                            matrizFichasUI[f, c].Fill = new SolidColorBrush(Color.FromRgb(217, 119, 6));
                            break;
                        default:
                            matrizFichasUI[f, c].Fill = Brushes.White;
                            break;
                    }
                    matrizFichasUI[f, c].Opacity = 1.0;
                }
            }
        }

        private void ActualizarInterfaz()
        {
            ActualizarMatrizVisual();

            string nombre = (juego.TurnoActual == Jugador.Rojo) ? TxtJugador1.Text : TxtJugador2.Text;
            LblTurnoActual.Text = $"Turno: {nombre}";
            LblTurnoActual.Foreground = (juego.TurnoActual == Jugador.Rojo)
                ? new SolidColorBrush(Color.FromRgb(220, 38, 38))
                : new SolidColorBrush(Color.FromRgb(217, 119, 6));
        }

        private void ActualizarMarcador()
        {
            LblMarcadorRojo.Text = $"{TxtJugador1.Text}: {victoriasRojo}";
            LblMarcadorAmarillo.Text = $"{TxtJugador2.Text}: {victoriasAmarillo}";
        }

        private void Ficha_MouseEnter(object sender, MouseEventArgs e)
        {
            if (juego.JuegoTerminado) return;
            if (juego.Modo == ModoJuego.HumanoVsIA && juego.TurnoActual == juego.JugadorIA) return;

            Ellipse elipse = sender as Ellipse;
            if (elipse != null && elipse.Fill == Brushes.White)
            {
                elipse.Opacity = 0.5;
                elipse.Fill = (juego.TurnoActual == Jugador.Rojo) ? Brushes.Red : Brushes.Orange;
            }
        }

        private void Ficha_MouseLeave(object sender, MouseEventArgs e)
        {
            Ellipse elipse = sender as Ellipse;
            if (elipse == null) return;

            int col = (int)elipse.Tag;
            for(int f= 0; f < TableroConecta4.Filas; f++)
            {
                if (matrizFichasUI[f,col] == elipse && juego.ObtenerCelda(f,col) == Jugador.Ninguno)
                {
                    elipse.Fill = Brushes.White;
                    elipse.Opacity = 1.0;
                }
            }
        }

        private void ChkModoIA_Changed(object sender, RoutedEventArgs e)
        {
            if (juego == null) return;

            if (ChkModoIA.IsChecked == true)
            {
                juego.Modo = ModoJuego.HumanoVsIA;
                TxtJugador2.Text = " Computadora";
                TxtJugador2.IsEnabled = false;
            }
            else
            {
                juego.Modo = ModoJuego.HumanoVsHumano;
                TxtJugador2.Text = "Alumno UNC 2";
                TxtJugador2.IsEnabled = true;
            }
            ActualizarMarcador();
        }

        private void BtnNuevoJuego_Click(object sender, RoutedEventArgs e)
        {
            juego.ReiniciarJuego();
            LstHistorial.Items.Clear();

            if (RbIniciaAmarillo.IsChecked == true && juego.TurnoActual == Jugador.Rojo)
            {
                juego.CambiarTurno();
            }

            ActualizarInterfaz();
            ActualizarMarcador();
            ReiniciarTimer();

            _ = EvaluarTurnoIA();
        }

        private void BtnResetContadores_Click(object sender, RoutedEventArgs e)
        {
            victoriasRojo = 0;
            victoriasAmarillo = 0;
            ActualizarMarcador();
        }

        private void ChkTemporizador_Changed(object sender, RoutedEventArgs e)
        {
            ReiniciarTimer();
        }

        private void CboTiempoTurno_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CboTiempoTurno.SelectedItem is ComboBoxItem item)
            {
                if (int.TryParse(item.Content.ToString(), out int segundos))
                {
                    limiteTiempo = segundos;
                    ReiniciarTimer();
                }
            }
        }

        private void BtnLimpiarHistorial_Click(object sender, RoutedEventArgs e)
        {
            LstHistorial.Items.Clear();
        }

        private void MnuSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MnuAcercaDe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Conecta 4 - Universidad Nacional de Cajamarca\nCurso: Programación Aplicada 1\nDesarrollado en WPF y C# con IA integrada.",
                            "Acerca de", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
