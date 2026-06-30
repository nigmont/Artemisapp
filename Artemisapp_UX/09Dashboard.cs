using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Artemisapp_UX
{
    public partial class _09Dashboard : Form
    {
        public _09Dashboard()
        {
            InitializeComponent();
        }

        private void _09Dashboard_Load(object sender, EventArgs e)
        {
            CargarGraficoTurnos();
            CargarGraficoTurnosAsignados();
            CargarResumenHoy();
        }

        private void CargarGraficoTurnos()
        {
            // 1. Obtenemos los datos del reporte (cuántos turnos por estado)
            REPORTES.ReporteTurnos reporte = new REPORTES.ReporteTurnos();
            Dictionary<string, int> datos = reporte.ContarTurnosPorEstado();

            // 2. Limpiamos el gráfico por si tenía algo
            chart1.Series.Clear();
            chart1.Titles.Clear();

            // 3. Le ponemos un título
            chart1.Titles.Add("Turnos por Estado");

            // 4. Creamos una serie y elegimos el tipo de gráfico (barras/columnas)
            Series serie = new Series("Turnos");
            serie.ChartType = SeriesChartType.Column;

            // 5. Recorremos el diccionario y agregamos un punto por cada estado
            foreach (KeyValuePair<string, int> par in datos)
            {
                serie.Points.AddXY(par.Key, par.Value);
            }

            // 6. Agregamos la serie al gráfico
            chart1.Series.Add(serie);
        }

        private void CargarGraficoTurnosAsignados()
        {
            // 1. Se obtiene los datos del reporte (cuántos turnos por día)
            REPORTES.ReporteTurnos reporte = new REPORTES.ReporteTurnos();
            Dictionary<string, int> datos = reporte.ContarTurnosPorDiaSemana();

            // 2. Limpiamos el gráfico por si tenía algo
            chart2.Series.Clear();
            chart2.Titles.Clear();

            // 3. Le ponemos un título elegante
            chart2.Titles.Add("Turnos por día de la semana");

            // 4. Se crea una serie y elegimos el tipo de gráfico de DONA
            Series serie = new Series("TurnosPorDia");
            serie.ChartType = SeriesChartType.Doughnut;

            // CAMBIO 1: Que adentro de la dona SOLO se dibuje el porcentaje (ej: 20%)
            serie.Label = "#PERCENT{P0}";

            // CAMBIO 2: Forzamos a que el texto se pinte ADENTRO de cada porción
            serie["PieLabelStyle"] = "Inside";

            // CAMBIO 3: Hacemos que la leyenda de abajo asocie el color con el Nombre del Día
            serie.LegendText = "#VALX";


            // 5. Se recorre el diccionario y agregamos un punto por cada día
            foreach (KeyValuePair<string, int> par in datos)
            {
                // Solo agregamos al gráfico si el día tiene turnos (mayor a 0) 
                if (par.Value > 0)
                {
                    serie.Points.AddXY(par.Key, par.Value);
                }
            }

            // 6. Agregamos la serie al gráfico
            chart2.Series.Add(serie);

            // Mueve los cuadraditos de las referencias (leyenda) abajo del gráfico
            if (chart2.Legends.Count > 0)
            {
                chart2.Legends[0].Docking = Docking.Bottom;
            }
        }

        // Este es el método nuevo que tenés que pegar en tu formulario:
        private void CargarResumenHoy()
        {
            // Instanciamos la clase de reportes que acabamos de actualizar
            REPORTES.ReporteTurnos reporte = new REPORTES.ReporteTurnos();

            // 1. Buscamos la cantidad de turnos de hoy y la asignamos al label numérico
            int cantidadHoy = reporte.ObtenerCantidadTurnosHoy();
            lblTurnosHoyValor.Text = cantidadHoy.ToString();

            // 2. Buscamos el detalle del próximo turno y lo asignamos al label de abajo
            string proximo = reporte.ObtenerProximoTurno();
            lblProximoValor.Text = proximo;
        }
    }
}


