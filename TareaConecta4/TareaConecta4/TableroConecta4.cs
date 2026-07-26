using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaConecta4
{
    public enum Jugador { Ninguno = 0, Rojo = 1, Amarillo = 2 }
    public enum ModoJuego { HumanoVsHumano, HumanoVsIA }

    public class TableroConecta4
    {
        public const int Filas = 6;
        public const int Columnas = 7;
        private Jugador[,] matrizTablero;

        public Jugador TurnoActual { get; private set; }
        public bool JuegoTerminado { get; private set; }

        public ModoJuego Modo { get; set; } = ModoJuego.HumanoVsHumano;
        public Jugador JugadorIA { get; set; } = Jugador.Amarillo;

        public TableroConecta4()
        {
            matrizTablero = new Jugador[Filas, Columnas]; 
            ReiniciarJuego();
        }

        public void ReiniciarJuego()
        {
            for (int f = 0; f < Filas; f++)
            {
                for (int c = 0; c < Columnas; c++)
                {
                    matrizTablero[f, c] = Jugador.Ninguno;
                }
            }
            TurnoActual = Jugador.Rojo;
            JuegoTerminado = false;
        }

        public Jugador ObtenerCelda(int fila, int columna)
        {
            if (fila >= 0 && fila < Filas && columna >= 0 && columna < Columnas)
                return matrizTablero[fila, columna];
            return Jugador.Ninguno;
        }

        public int SoltarFicha(int columna)
        {
            if (JuegoTerminado || columna < 0 || columna >= Columnas)
                return -1;

            for (int f = Filas - 1; f >= 0; f--)
            {
                if (matrizTablero[f, columna] == Jugador.Ninguno)
                {
                    matrizTablero[f, columna] = TurnoActual;
                    return f;
                }
            }
            return -1;
        }

        public void CambiarTurno()
        {
            TurnoActual = (TurnoActual == Jugador.Rojo) ? Jugador.Amarillo : Jugador.Rojo;
        }

        public bool VerificarGanador(int fila, int columna)
        {
            Jugador j = matrizTablero[fila, columna];
            if (j == Jugador.Ninguno) return false;

            int[,] direcciones = new int[,] {
                { 0, 1 },  
                { 1, 0 },  
                { 1, 1 }, 
                { 1, -1 } 
            };

            for (int d = 0; d < 4; d++)
            {
                int contador = 1;
                int dirFila = direcciones[d, 0];
                int dirCol = direcciones[d, 1];

                contador += ContarEnDireccion(fila, columna, dirFila, dirCol, j);
                contador += ContarEnDireccion(fila, columna, -dirFila, -dirCol, j);

                if (contador >= 4)
                {
                    JuegoTerminado = true;
                    return true;
                }
            }

            return false;
        }

        private int ContarEnDireccion(int fila, int columna, int deltaFila, int deltaCol, Jugador j)
        {
            int count = 0;
            int f = fila + deltaFila;
            int c = columna + deltaCol;

            while (f >= 0 && f < Filas && c >= 0 && c < Columnas && matrizTablero[f, c] == j)
            {
                count++;
                f += deltaFila;
                c += deltaCol;
            }

            return count;
        }

        public bool EsEmpate()
        {
            if (JuegoTerminado) return false;

            for (int c = 0; c < Columnas; c++)
            {
                if (matrizTablero[0, c] == Jugador.Ninguno)
                    return false;
            }

            JuegoTerminado = true;
            return true;
        }

        public (int fila, int columna) ObtenerJugadaIA()
        {
            if (JuegoTerminado) return (-1, -1);

            for (int col = 0; col < Columnas; col++)
            {
                int filaSimulada = SoltarFichaSimulada(col, JugadorIA);
                if (filaSimulada != -1)
                {
                    if (VerificarGanadorSimulado(filaSimulada, col, JugadorIA))
                    {
                        int filaReal = SoltarFicha(col);
                        return (filaReal, col);
                    }
                }
            }

            Jugador humano = (JugadorIA == Jugador.Rojo) ? Jugador.Amarillo : Jugador.Rojo;
            for (int col = 0; col < Columnas; col++)
            {
                int filaSimulada = SoltarFichaSimulada(col, humano);
                if (filaSimulada != -1)
                {
                    if (VerificarGanadorSimulado(filaSimulada, col, humano))
                    {
                        int filaReal = SoltarFicha(col);
                        return (filaReal, col);
                    }
                }
            }

            int[] ordenColumnas = { 3, 2, 4, 1, 5, 0, 6 };
            foreach (int col in ordenColumnas)
            {
                int filaReal = SoltarFicha(col);
                if (filaReal != -1)
                {
                    return (filaReal, col);
                }
            }

            return (-1, -1);
        }

        private int SoltarFichaSimulada(int columna, Jugador jugador)
        {
            for (int f = Filas - 1; f >= 0; f--)
            {
                if (matrizTablero[f, columna] == Jugador.Ninguno)
                    return f;
            }
            return -1;
        }

        private bool VerificarGanadorSimulado(int fila, int columna, Jugador j)
        {
            matrizTablero[fila, columna] = j;
            bool gano = VerificarGanador(fila, columna);
            matrizTablero[fila, columna] = Jugador.Ninguno;
            JuegoTerminado = false;
            return gano;
        }
    }
}
