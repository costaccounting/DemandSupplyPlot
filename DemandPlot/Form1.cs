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

namespace DemandPlot
{
    /*
    The main Math class
    Contains all methods for performing basic math functions
    */
    /// <author>
    /// Prodip Mitra 
    /// </author>
    /// <summary>
    /// The main form class.
    /// Contains all methods for graph functions.
    /// </summary>
    public partial class Form1 : Form
    {
        private static Process ps = new Process();
        private static Dao dao = new Dao();
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnAddDemand_Click(object sender, EventArgs e)
        {
            // counting the number of textboxes in the panel
            int count = (panel1.Controls.OfType<TextBox>().ToList().Count);
            int i = count / 2;
            if (i < 5) { 
                CreateSupplyInput(i);
            }
            // message shown when more than 5 points were created
            else
                System.Windows.Forms.MessageBox.Show("5 points max");

        }

        private void grpDemand_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = (panel2.Controls.OfType<TextBox>().ToList().Count);
            int i = count / 2;
            //condition to check if the total number of points exceeds 500
            if (i < 500)
            {
                CreateDemandInput(i);
            }
            // message shown when more than 500 points were entered
            else
                System.Windows.Forms.MessageBox.Show("500 points max");

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();
            var chartArea = new ChartArea();
            dao = new Dao();
            // chart area properties
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisX.Maximum = 1000;
            chartArea.AxisY.Maximum = 1000;

            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisX.LabelStyle.Font = new Font("Consolas", 6);
            chartArea.AxisY.LabelStyle.Font = new Font("Consolas", 6);
            
            chart1.ChartAreas.Add(chartArea);

            //counting demand and supply points
            int demandCount = (panel2.Controls.OfType<TextBox>().ToList().Count);
            int supplyCount = (panel1.Controls.OfType<TextBox>().ToList().Count);

                       
            for(int i = 0; i<demandCount; i+=2)
            {
                //validating the inputs for demand
                try
                {
                    double x = Convert.ToDouble((panel2.Controls.OfType<TextBox>().ToList()[i].Text));
                    double y = Convert.ToDouble((panel2.Controls.OfType<TextBox>().ToList()[i + 1].Text));
                    if (x < 0 || y < 0) throw new FormatException();
                    Point p = new Point(x, y);
                    dao.demandListAdd(p);
                }
                catch (FormatException ex)
                {
                    System.Windows.Forms.MessageBox.Show("Enter positive numbers only");

                }
                
                
            }

            for (int i = 0; i < supplyCount; i += 2)
            {
                // validating the inpurs for supply
                try
                {
                    double x = Convert.ToDouble((panel1.Controls.OfType<TextBox>().ToList()[i].Text));
                    double y = Convert.ToDouble((panel1.Controls.OfType<TextBox>().ToList()[i + 1].Text));
                    if (x < 0 || y < 0) throw new FormatException();
                    Point p = new Point(x, y);

                    dao.supplyListAdd(p);
                }
                catch (FormatException ex)
                {
                    System.Windows.Forms.MessageBox.Show("Enter positive numbers only");

                }
            }

            //supply points
            List<Point> supplydata = dao.GetSupplyDataSet();
            //demand points
            List<Point> demanddata = dao.GetDemandDataSet();
            //line parameters for chart
            List<double[]> lines = new List<double[]>();
            //list of colours used 
            Color[] color = new Color[] { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Pink };

            for (int i = 0; i < demanddata.Count; i++)
            {
                //generate a line with the closest supply point from the demand point.
                double[] line = ps.GetLine(demanddata[i], supplydata);

                //assigning a series
                Series s = new Series("series" + i);
                // assigning start and end points for the series                
                s.Points.DataBindXY(new[] { line[0], line[2] }, new[] { line[1], line[3] });
                //assigning chart type as line chart
                s.ChartType = SeriesChartType.Line;
                //assigning color to line based on having a common supply point
                try
                {
                    for (int j = 0; j < supplydata.Count; j++)
                    {
                        Point x = new Point(line[2], line[3]);
                        Point sup = supplydata[j];
                        if (x.IsEqual(sup))
                        {
                            s.Color = color[j];
                        }


                    }
                }
                catch (Exception)
                {

                    throw;
                }

                chart1.Series.Add(s);

            }
            chart1.Legends.Clear();



        }

        private void btnAutoSupply_Click(object sender, EventArgs e)
        {
            int count;
            for (int j = 0; j < 5; j++) {
                count = (panel1.Controls.OfType<TextBox>().ToList().Count);
                int i = count / 2;
                // end iteration if maximum of 5 points has been specified
                if (i < 5)
                {
                    CreateSupplyInput(i);
                }
                // message shown when more than 5 points were created
                else
                {
                    System.Windows.Forms.MessageBox.Show("5 points max");
                    break;
                }
            }
        }

        private void btnAutoDemand_Click(object sender, EventArgs e)
        {
            int count;
            for (int j = 0; j < 500; j++)
            {
                
                count = (panel2.Controls.OfType<TextBox>().ToList().Count);
                int i = count / 2;
                if (i < 500)
                {
                    CreateDemandInput(i);
                }
                // message shown when more than 5 points were created
                else
                {
                    System.Windows.Forms.MessageBox.Show("500 points max");
                    break;
                }
                    

            }

        }
        private void CreateDemandInput(int i)
        {
            TextBox textbox = new TextBox();
            TextBox textbox2 = new TextBox();


            textbox.Location = new System.Drawing.Point(3, 25 * (i + 1));
            textbox.Size = new System.Drawing.Size(80, 20);
            textbox.Name = "demandx_" + (i);
            //generating random number for textbox
            textbox.Text = Convert.ToString(random.Next(0, 1000));
            panel2.Controls.Add(textbox);

            textbox2.Location = new System.Drawing.Point(89, 25 * (i + 1));
            textbox2.Size = new System.Drawing.Size(80, 20);
            textbox2.Name = "demandy_" + (i);
            //generating random number for textbox
            textbox2.Text = Convert.ToString(random.Next(0, 1000));
            panel2.Controls.Add(textbox2);
        }
        private void CreateSupplyInput(int i)
        {
            TextBox textbox = new TextBox();
            TextBox textbox2 = new TextBox();

            // adding textbox for x axis value input
            textbox.Location = new System.Drawing.Point(3, 25 * (i + 1));
            textbox.Size = new System.Drawing.Size(80, 20);
            textbox.Name = "supplyx_" + (i);
            //filling the textbox with a random number
            textbox.Text = Convert.ToString(random.Next(0, 1000));
            panel1.Controls.Add(textbox);

            //adding textbox for y axis value input
            textbox2.Location = new System.Drawing.Point(90, 25 * (i + 1));
            textbox2.Size = new System.Drawing.Size(80, 20);
            textbox2.Name = "supplyy_" + (i);
            //filling the textbox with a random number
            textbox2.Text = Convert.ToString(random.Next(0, 1000));
            panel1.Controls.Add(textbox2);
        }
    }
    
}
