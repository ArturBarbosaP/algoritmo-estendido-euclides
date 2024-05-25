namespace AlgoritmoEstendidoEuclides
{
    partial class frm_algoritmo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_calcular = new Button();
            num_a = new NumericUpDown();
            num_b = new NumericUpDown();
            lbl_numa = new Label();
            lbl_numb = new Label();
            ltx_passo = new ListBox();
            ((System.ComponentModel.ISupportInitialize)num_a).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_b).BeginInit();
            SuspendLayout();
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(38, 44);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(301, 27);
            btn_calcular.TabIndex = 2;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // num_a
            // 
            num_a.Location = new Point(109, 16);
            num_a.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            num_a.Name = "num_a";
            num_a.Size = new Size(65, 23);
            num_a.TabIndex = 0;
            // 
            // num_b
            // 
            num_b.Location = new Point(274, 16);
            num_b.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            num_b.Name = "num_b";
            num_b.Size = new Size(65, 23);
            num_b.TabIndex = 1;
            // 
            // lbl_numa
            // 
            lbl_numa.AutoSize = true;
            lbl_numa.Location = new Point(38, 20);
            lbl_numa.Name = "lbl_numa";
            lbl_numa.Size = new Size(65, 15);
            lbl_numa.TabIndex = 4;
            lbl_numa.Text = "Número A:";
            // 
            // lbl_numb
            // 
            lbl_numb.AutoSize = true;
            lbl_numb.Location = new Point(204, 20);
            lbl_numb.Name = "lbl_numb";
            lbl_numb.Size = new Size(64, 15);
            lbl_numb.TabIndex = 5;
            lbl_numb.Text = "Número B:";
            // 
            // ltx_passo
            // 
            ltx_passo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ltx_passo.FormattingEnabled = true;
            ltx_passo.ItemHeight = 32;
            ltx_passo.Location = new Point(38, 77);
            ltx_passo.Name = "ltx_passo";
            ltx_passo.SelectionMode = SelectionMode.None;
            ltx_passo.Size = new Size(301, 324);
            ltx_passo.TabIndex = 6;
            // 
            // frm_algoritmo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 416);
            Controls.Add(ltx_passo);
            Controls.Add(lbl_numb);
            Controls.Add(lbl_numa);
            Controls.Add(num_b);
            Controls.Add(num_a);
            Controls.Add(btn_calcular);
            Name = "frm_algoritmo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Algoritmo Estendido de Euclides";
            ((System.ComponentModel.ISupportInitialize)num_a).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_b).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_calcular;
        private NumericUpDown num_a;
        private NumericUpDown num_b;
        private Label lbl_numa;
        private Label lbl_numb;
        private ListBox ltx_passo;
    }
}
