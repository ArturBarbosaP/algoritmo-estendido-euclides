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
            txt_resultado = new TextBox();
            btn_calcular = new Button();
            txt_numB = new TextBox();
            txt_numA = new TextBox();
            SuspendLayout();
            // 
            // txt_resultado
            // 
            txt_resultado.Font = new Font("Segoe UI", 18F);
            txt_resultado.Location = new Point(38, 74);
            txt_resultado.Multiline = true;
            txt_resultado.Name = "txt_resultado";
            txt_resultado.ReadOnly = true;
            txt_resultado.Size = new Size(301, 364);
            txt_resultado.TabIndex = 3;
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(38, 41);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(301, 27);
            btn_calcular.TabIndex = 2;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // txt_numB
            // 
            txt_numB.Location = new Point(248, 12);
            txt_numB.Name = "txt_numB";
            txt_numB.PlaceholderText = "Número B";
            txt_numB.Size = new Size(91, 23);
            txt_numB.TabIndex = 1;
            // 
            // txt_numA
            // 
            txt_numA.Location = new Point(38, 12);
            txt_numA.Name = "txt_numA";
            txt_numA.PlaceholderText = "Número A";
            txt_numA.Size = new Size(91, 23);
            txt_numA.TabIndex = 0;
            // 
            // frm_algoritmo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 450);
            Controls.Add(txt_resultado);
            Controls.Add(btn_calcular);
            Controls.Add(txt_numB);
            Controls.Add(txt_numA);
            Name = "frm_algoritmo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Algoritmo Estendido de Euclides";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_resultado;
        private Button btn_calcular;
        private TextBox txt_numB;
        private TextBox txt_numA;
    }
}
