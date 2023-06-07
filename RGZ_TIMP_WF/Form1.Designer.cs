namespace RGZ_TIMP_WF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.InfoPieChartDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PieChartPictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.PieChartButton = new System.Windows.Forms.Button();
            this.LineChartButton = new System.Windows.Forms.Button();
            this.BarChartButton = new System.Windows.Forms.Button();
            this.DeleteLastChartButton = new System.Windows.Forms.Button();
            this.CreateXYbutton = new System.Windows.Forms.Button();
            this.PieChartDataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XYDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LineChartInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineChartPictureBox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BarChartInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarChartPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPieChartDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChartPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PieChartDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XYDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineChartInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineChartPictureBox)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarChartInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarChartPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.InfoPieChartDataGridView);
            this.panel1.Controls.Add(this.PieChartPictureBox);
            this.panel1.Location = new System.Drawing.Point(9, 448);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 340);
            this.panel1.TabIndex = 0;
            // 
            // InfoPieChartDataGridView
            // 
            this.InfoPieChartDataGridView.AllowUserToAddRows = false;
            this.InfoPieChartDataGridView.AllowUserToDeleteRows = false;
            this.InfoPieChartDataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.InfoPieChartDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoPieChartDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.InfoPieChartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoPieChartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2});
            this.InfoPieChartDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.InfoPieChartDataGridView.Location = new System.Drawing.Point(396, 0);
            this.InfoPieChartDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InfoPieChartDataGridView.Name = "InfoPieChartDataGridView";
            this.InfoPieChartDataGridView.ReadOnly = true;
            this.InfoPieChartDataGridView.RowHeadersVisible = false;
            this.InfoPieChartDataGridView.RowHeadersWidth = 51;
            this.InfoPieChartDataGridView.RowTemplate.Height = 24;
            this.InfoPieChartDataGridView.Size = new System.Drawing.Size(167, 338);
            this.InfoPieChartDataGridView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Цвет";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 50;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Число";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "%";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 60;
            // 
            // PieChartPictureBox
            // 
            this.PieChartPictureBox.BackColor = System.Drawing.Color.LightGray;
            this.PieChartPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PieChartPictureBox.Location = new System.Drawing.Point(0, 0);
            this.PieChartPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PieChartPictureBox.Name = "PieChartPictureBox";
            this.PieChartPictureBox.Size = new System.Drawing.Size(563, 338);
            this.PieChartPictureBox.TabIndex = 0;
            this.PieChartPictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ErrorLabel);
            this.panel2.Controls.Add(this.PieChartButton);
            this.panel2.Controls.Add(this.LineChartButton);
            this.panel2.Controls.Add(this.BarChartButton);
            this.panel2.Controls.Add(this.DeleteLastChartButton);
            this.panel2.Controls.Add(this.CreateXYbutton);
            this.panel2.Controls.Add(this.PieChartDataGridView);
            this.panel2.Controls.Add(this.XYDataGridView);
            this.panel2.Location = new System.Drawing.Point(9, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 434);
            this.panel2.TabIndex = 1;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ErrorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ErrorLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.Location = new System.Drawing.Point(286, 318);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(275, 112);
            this.ErrorLabel.TabIndex = 7;
            // 
            // PieChartButton
            // 
            this.PieChartButton.Location = new System.Drawing.Point(387, 258);
            this.PieChartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PieChartButton.Name = "PieChartButton";
            this.PieChartButton.Size = new System.Drawing.Size(174, 54);
            this.PieChartButton.TabIndex = 6;
            this.PieChartButton.Text = "Нарисовать круговую диаграмму";
            this.PieChartButton.UseVisualStyleBackColor = true;
            this.PieChartButton.Click += new System.EventHandler(this.PieChartButton_Click);
            // 
            // LineChartButton
            // 
            this.LineChartButton.Location = new System.Drawing.Point(144, 376);
            this.LineChartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LineChartButton.Name = "LineChartButton";
            this.LineChartButton.Size = new System.Drawing.Size(138, 54);
            this.LineChartButton.TabIndex = 5;
            this.LineChartButton.Text = "Нарисовать кусочно-линейную диаграмму";
            this.LineChartButton.UseVisualStyleBackColor = true;
            this.LineChartButton.Click += new System.EventHandler(this.LineChartButton_Click);
            // 
            // BarChartButton
            // 
            this.BarChartButton.Location = new System.Drawing.Point(2, 376);
            this.BarChartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BarChartButton.Name = "BarChartButton";
            this.BarChartButton.Size = new System.Drawing.Size(138, 54);
            this.BarChartButton.TabIndex = 4;
            this.BarChartButton.Text = "Нарисовать столбчатую диаграмму";
            this.BarChartButton.UseVisualStyleBackColor = true;
            this.BarChartButton.Click += new System.EventHandler(this.BarChartButton_Click);
            // 
            // DeleteLastChartButton
            // 
            this.DeleteLastChartButton.Location = new System.Drawing.Point(144, 318);
            this.DeleteLastChartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteLastChartButton.Name = "DeleteLastChartButton";
            this.DeleteLastChartButton.Size = new System.Drawing.Size(138, 54);
            this.DeleteLastChartButton.TabIndex = 3;
            this.DeleteLastChartButton.Text = "Удалить последний график";
            this.DeleteLastChartButton.UseVisualStyleBackColor = true;
            this.DeleteLastChartButton.Click += new System.EventHandler(this.DeleteLastChartButton_Click);
            // 
            // CreateXYbutton
            // 
            this.CreateXYbutton.Location = new System.Drawing.Point(2, 318);
            this.CreateXYbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateXYbutton.Name = "CreateXYbutton";
            this.CreateXYbutton.Size = new System.Drawing.Size(138, 54);
            this.CreateXYbutton.TabIndex = 2;
            this.CreateXYbutton.Text = "Добавить график";
            this.CreateXYbutton.UseVisualStyleBackColor = true;
            this.CreateXYbutton.Click += new System.EventHandler(this.CreateXYbutton_Click);
            // 
            // PieChartDataGridView
            // 
            this.PieChartDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.PieChartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PieChartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnValues});
            this.PieChartDataGridView.Location = new System.Drawing.Point(387, 2);
            this.PieChartDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PieChartDataGridView.Name = "PieChartDataGridView";
            this.PieChartDataGridView.RowHeadersWidth = 51;
            this.PieChartDataGridView.RowTemplate.Height = 24;
            this.PieChartDataGridView.Size = new System.Drawing.Size(174, 250);
            this.PieChartDataGridView.TabIndex = 1;
            // 
            // ColumnValues
            // 
            this.ColumnValues.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnValues.HeaderText = "Значения для круговой диаграммы";
            this.ColumnValues.MinimumWidth = 6;
            this.ColumnValues.Name = "ColumnValues";
            // 
            // XYDataGridView
            // 
            this.XYDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.XYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.XYDataGridView.Location = new System.Drawing.Point(2, 2);
            this.XYDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.XYDataGridView.Name = "XYDataGridView";
            this.XYDataGridView.RowHeadersWidth = 51;
            this.XYDataGridView.RowTemplate.Height = 24;
            this.XYDataGridView.Size = new System.Drawing.Size(380, 309);
            this.XYDataGridView.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.LineChartInfoDataGridView);
            this.panel3.Controls.Add(this.LineChartPictureBox);
            this.panel3.Location = new System.Drawing.Point(578, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(695, 387);
            this.panel3.TabIndex = 2;
            // 
            // LineChartInfoDataGridView
            // 
            this.LineChartInfoDataGridView.AllowUserToAddRows = false;
            this.LineChartInfoDataGridView.AllowUserToDeleteRows = false;
            this.LineChartInfoDataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.LineChartInfoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LineChartInfoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.LineChartInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LineChartInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.LineChartInfoDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.LineChartInfoDataGridView.Location = new System.Drawing.Point(591, 0);
            this.LineChartInfoDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LineChartInfoDataGridView.Name = "LineChartInfoDataGridView";
            this.LineChartInfoDataGridView.ReadOnly = true;
            this.LineChartInfoDataGridView.RowHeadersVisible = false;
            this.LineChartInfoDataGridView.RowHeadersWidth = 51;
            this.LineChartInfoDataGridView.RowTemplate.Height = 24;
            this.LineChartInfoDataGridView.Size = new System.Drawing.Size(102, 385);
            this.LineChartInfoDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Цвет";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "№";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LineChartPictureBox
            // 
            this.LineChartPictureBox.BackColor = System.Drawing.Color.LightGray;
            this.LineChartPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LineChartPictureBox.Location = new System.Drawing.Point(0, 0);
            this.LineChartPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LineChartPictureBox.Name = "LineChartPictureBox";
            this.LineChartPictureBox.Size = new System.Drawing.Size(693, 385);
            this.LineChartPictureBox.TabIndex = 0;
            this.LineChartPictureBox.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.BarChartInfoDataGridView);
            this.panel4.Controls.Add(this.BarChartPictureBox);
            this.panel4.Location = new System.Drawing.Point(578, 401);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(695, 387);
            this.panel4.TabIndex = 3;
            // 
            // BarChartInfoDataGridView
            // 
            this.BarChartInfoDataGridView.AllowUserToAddRows = false;
            this.BarChartInfoDataGridView.AllowUserToDeleteRows = false;
            this.BarChartInfoDataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.BarChartInfoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BarChartInfoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BarChartInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BarChartInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.BarChartInfoDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.BarChartInfoDataGridView.Location = new System.Drawing.Point(591, 0);
            this.BarChartInfoDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BarChartInfoDataGridView.Name = "BarChartInfoDataGridView";
            this.BarChartInfoDataGridView.ReadOnly = true;
            this.BarChartInfoDataGridView.RowHeadersVisible = false;
            this.BarChartInfoDataGridView.RowHeadersWidth = 51;
            this.BarChartInfoDataGridView.RowTemplate.Height = 24;
            this.BarChartInfoDataGridView.Size = new System.Drawing.Size(102, 385);
            this.BarChartInfoDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Цвет";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "№";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BarChartPictureBox
            // 
            this.BarChartPictureBox.BackColor = System.Drawing.Color.LightGray;
            this.BarChartPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarChartPictureBox.Location = new System.Drawing.Point(0, 0);
            this.BarChartPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BarChartPictureBox.Name = "BarChartPictureBox";
            this.BarChartPictureBox.Size = new System.Drawing.Size(693, 385);
            this.BarChartPictureBox.TabIndex = 0;
            this.BarChartPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 798);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Построитель диаграмм";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfoPieChartDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChartPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PieChartDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XYDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LineChartInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineChartPictureBox)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarChartInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarChartPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView XYDataGridView;
        private System.Windows.Forms.Button LineChartButton;
        private System.Windows.Forms.Button BarChartButton;
        private System.Windows.Forms.Button DeleteLastChartButton;
        private System.Windows.Forms.Button CreateXYbutton;
        private System.Windows.Forms.DataGridView PieChartDataGridView;
        private System.Windows.Forms.Button PieChartButton;
        private System.Windows.Forms.PictureBox PieChartPictureBox;
        private System.Windows.Forms.PictureBox LineChartPictureBox;
        private System.Windows.Forms.PictureBox BarChartPictureBox;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.DataGridView InfoPieChartDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValues;
        private System.Windows.Forms.DataGridView LineChartInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView BarChartInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

