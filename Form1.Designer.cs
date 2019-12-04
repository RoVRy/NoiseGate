namespace NoiseGate
{
    partial class MainWindow
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
                NoiseShaper.CancelAsync();
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            this.KDelta = new System.Windows.Forms.NumericUpDown();
            this.SensorType = new System.Windows.Forms.ComboBox();
            this.SensorValue = new System.Windows.Forms.NumericUpDown();
            this.FilterAmount = new System.Windows.Forms.NumericUpDown();
            this.NoiseLevel = new System.Windows.Forms.NumericUpDown();
            this.DeltaText = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DeltaSignal = new System.Windows.Forms.Label();
            this.InputSignal = new System.Windows.Forms.Label();
            this.FilteredSignal = new System.Windows.Forms.Label();
            this.NoiseShaper = new System.ComponentModel.BackgroundWorker();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KDelta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SensorValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoiseLevel)).BeginInit();
            groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 13);
            label1.TabIndex = 1;
            label1.Text = "Тип датчика:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 13);
            label2.TabIndex = 3;
            label2.Text = "Сигнал:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 80);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(50, 13);
            label3.TabIndex = 4;
            label3.Text = "Помеха:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 106);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(124, 13);
            label4.TabIndex = 6;
            label4.Text = "Степень фильтрации:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 132);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(54, 13);
            label5.TabIndex = 8;
            label5.Text = "К дельта:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(this.KDelta);
            groupBox1.Controls.Add(this.SensorType);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(this.SensorValue);
            groupBox1.Controls.Add(this.FilterAmount);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(this.NoiseLevel);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(194, 165);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Настройки сигнала";
            // 
            // KDelta
            // 
            this.KDelta.Location = new System.Drawing.Point(128, 130);
            this.KDelta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.KDelta.Name = "KDelta";
            this.KDelta.Size = new System.Drawing.Size(52, 22);
            this.KDelta.TabIndex = 9;
            this.KDelta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SensorType
            // 
            this.SensorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SensorType.FormattingEnabled = true;
            this.SensorType.Items.AddRange(new object[] {
            "0-5 мА",
            "0-20 мА",
            "4-20 мА"});
            this.SensorType.Location = new System.Drawing.Point(102, 25);
            this.SensorType.Name = "SensorType";
            this.SensorType.Size = new System.Drawing.Size(78, 21);
            this.SensorType.TabIndex = 0;
            this.SensorType.SelectedIndexChanged += new System.EventHandler(this.SensorType_SelectedIndexChanged);
            this.SensorType.TextChanged += new System.EventHandler(this.SensorType_TextChanged);
            // 
            // SensorValue
            // 
            this.SensorValue.DecimalPlaces = 2;
            this.SensorValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.SensorValue.Location = new System.Drawing.Point(128, 52);
            this.SensorValue.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.SensorValue.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.SensorValue.Name = "SensorValue";
            this.SensorValue.Size = new System.Drawing.Size(52, 22);
            this.SensorValue.TabIndex = 2;
            this.SensorValue.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // FilterAmount
            // 
            this.FilterAmount.Location = new System.Drawing.Point(128, 104);
            this.FilterAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FilterAmount.Name = "FilterAmount";
            this.FilterAmount.Size = new System.Drawing.Size(52, 22);
            this.FilterAmount.TabIndex = 7;
            this.FilterAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NoiseLevel
            // 
            this.NoiseLevel.DecimalPlaces = 3;
            this.NoiseLevel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.NoiseLevel.Location = new System.Drawing.Point(128, 78);
            this.NoiseLevel.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NoiseLevel.Name = "NoiseLevel";
            this.NoiseLevel.Size = new System.Drawing.Size(52, 22);
            this.NoiseLevel.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.DeltaText);
            groupBox2.Controls.Add(this.label9);
            groupBox2.Controls.Add(this.DeltaSignal);
            groupBox2.Controls.Add(this.InputSignal);
            groupBox2.Controls.Add(this.FilteredSignal);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new System.Drawing.Point(212, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(231, 150);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Результаты";
            // 
            // DeltaText
            // 
            this.DeltaText.AutoSize = true;
            this.DeltaText.Location = new System.Drawing.Point(124, 106);
            this.DeltaText.Name = "DeltaText";
            this.DeltaText.Size = new System.Drawing.Size(0, 13);
            this.DeltaText.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Дельта:";
            // 
            // DeltaSignal
            // 
            this.DeltaSignal.AutoSize = true;
            this.DeltaSignal.Location = new System.Drawing.Point(124, 80);
            this.DeltaSignal.Name = "DeltaSignal";
            this.DeltaSignal.Size = new System.Drawing.Size(0, 13);
            this.DeltaSignal.TabIndex = 5;
            // 
            // InputSignal
            // 
            this.InputSignal.AutoSize = true;
            this.InputSignal.Location = new System.Drawing.Point(124, 28);
            this.InputSignal.Name = "InputSignal";
            this.InputSignal.Size = new System.Drawing.Size(0, 13);
            this.InputSignal.TabIndex = 4;
            // 
            // FilteredSignal
            // 
            this.FilteredSignal.AutoSize = true;
            this.FilteredSignal.Location = new System.Drawing.Point(124, 54);
            this.FilteredSignal.Name = "FilteredSignal";
            this.FilteredSignal.Size = new System.Drawing.Size(0, 13);
            this.FilteredSignal.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 80);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(102, 13);
            label8.TabIndex = 2;
            label8.Text = "Сигнал с дельтой:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 54);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(117, 13);
            label7.TabIndex = 1;
            label7.Text = "Сглаженный сигнал:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 28);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(95, 13);
            label6.TabIndex = 0;
            label6.Text = "Входной сигнал:";
            // 
            // NoiseShaper
            // 
            this.NoiseShaper.WorkerReportsProgress = true;
            this.NoiseShaper.WorkerSupportsCancellation = true;
            this.NoiseShaper.DoWork += new System.ComponentModel.DoWorkEventHandler(this.NoiseShaper_DoWork);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 190);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Сглаживание шума";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KDelta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SensorValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilterAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoiseLevel)).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.NumericUpDown FilterAmount;
        public System.Windows.Forms.NumericUpDown SensorValue;
        public System.Windows.Forms.NumericUpDown NoiseLevel;
        public System.Windows.Forms.NumericUpDown KDelta;
        public System.ComponentModel.BackgroundWorker NoiseShaper;
        public System.Windows.Forms.ComboBox SensorType;
        public System.Windows.Forms.Label InputSignal;
        public System.Windows.Forms.Label FilteredSignal;
        public System.Windows.Forms.Label DeltaSignal;
        private System.Windows.Forms.Label DeltaText;
        private System.Windows.Forms.Label label9;
    }
}

