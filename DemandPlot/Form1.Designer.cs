namespace DemandPlot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSupply = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddSupply = new System.Windows.Forms.Button();
            this.grpDemand = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddDemand = new System.Windows.Forms.Button();
            this.btnPlot = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAutoSupply = new System.Windows.Forms.Button();
            this.btnAutoDemand = new System.Windows.Forms.Button();
            this.grpSupply.SuspendLayout();
            this.grpDemand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Demand and Supply Plotter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpSupply
            // 
            this.grpSupply.Controls.Add(this.btnAutoSupply);
            this.grpSupply.Controls.Add(this.panel1);
            this.grpSupply.Controls.Add(this.btnAddSupply);
            this.grpSupply.Location = new System.Drawing.Point(13, 103);
            this.grpSupply.Name = "grpSupply";
            this.grpSupply.Size = new System.Drawing.Size(318, 193);
            this.grpSupply.TabIndex = 1;
            this.grpSupply.TabStop = false;
            this.grpSupply.Text = "Supply Points";
            this.grpSupply.Enter += new System.EventHandler(this.grpDemand_Enter);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(8, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 168);
            this.panel1.TabIndex = 4;
            // 
            // btnAddSupply
            // 
            this.btnAddSupply.Location = new System.Drawing.Point(246, 20);
            this.btnAddSupply.Name = "btnAddSupply";
            this.btnAddSupply.Size = new System.Drawing.Size(61, 42);
            this.btnAddSupply.TabIndex = 2;
            this.btnAddSupply.Text = "Add new point";
            this.btnAddSupply.UseVisualStyleBackColor = true;
            this.btnAddSupply.Click += new System.EventHandler(this.btnAddDemand_Click);
            // 
            // grpDemand
            // 
            this.grpDemand.Controls.Add(this.btnAutoDemand);
            this.grpDemand.Controls.Add(this.panel2);
            this.grpDemand.Controls.Add(this.btnAddDemand);
            this.grpDemand.Location = new System.Drawing.Point(13, 302);
            this.grpDemand.Name = "grpDemand";
            this.grpDemand.Size = new System.Drawing.Size(318, 216);
            this.grpDemand.TabIndex = 2;
            this.grpDemand.TabStop = false;
            this.grpDemand.Text = "Demand Points";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(8, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 191);
            this.panel2.TabIndex = 7;
            // 
            // btnAddDemand
            // 
            this.btnAddDemand.Location = new System.Drawing.Point(246, 22);
            this.btnAddDemand.Name = "btnAddDemand";
            this.btnAddDemand.Size = new System.Drawing.Size(61, 42);
            this.btnAddDemand.TabIndex = 5;
            this.btnAddDemand.Text = "Add new point";
            this.btnAddDemand.UseVisualStyleBackColor = true;
            this.btnAddDemand.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlot
            // 
            this.btnPlot.Location = new System.Drawing.Point(13, 64);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(75, 23);
            this.btnPlot.TabIndex = 3;
            this.btnPlot.Text = "Plot";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 19);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(609, 372);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Location = new System.Drawing.Point(337, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(658, 409);
            this.panel3.TabIndex = 5;
            // 
            // btnAutoSupply
            // 
            this.btnAutoSupply.Location = new System.Drawing.Point(247, 69);
            this.btnAutoSupply.Name = "btnAutoSupply";
            this.btnAutoSupply.Size = new System.Drawing.Size(61, 42);
            this.btnAutoSupply.TabIndex = 5;
            this.btnAutoSupply.Text = "Auto add 5 points";
            this.btnAutoSupply.UseVisualStyleBackColor = true;
            this.btnAutoSupply.Click += new System.EventHandler(this.btnAutoSupply_Click);
            // 
            // btnAutoDemand
            // 
            this.btnAutoDemand.Location = new System.Drawing.Point(247, 71);
            this.btnAutoDemand.Name = "btnAutoDemand";
            this.btnAutoDemand.Size = new System.Drawing.Size(61, 53);
            this.btnAutoDemand.TabIndex = 8;
            this.btnAutoDemand.Text = "Auto add 500 points";
            this.btnAutoDemand.UseVisualStyleBackColor = true;
            this.btnAutoDemand.Click += new System.EventHandler(this.btnAutoDemand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 530);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnPlot);
            this.Controls.Add(this.grpDemand);
            this.Controls.Add(this.grpSupply);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpSupply.ResumeLayout(false);
            this.grpDemand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSupply;
        private System.Windows.Forms.Button btnAddSupply;
        private System.Windows.Forms.GroupBox grpDemand;
        private System.Windows.Forms.Button btnAddDemand;
        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAutoSupply;
        private System.Windows.Forms.Button btnAutoDemand;
    }
}

