namespace WinFormsTabla
{
    partial class Form1
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
            panelPrincipal = new Panel();
            richTextBoxResultados = new RichTextBox();
            buttonVer = new Button();
            textBoxNum = new TextBox();
            label1 = new Label();
            labeltitulo = new Label();
            label2 = new Label();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(192, 192, 255);
            panelPrincipal.Controls.Add(label2);
            panelPrincipal.Controls.Add(richTextBoxResultados);
            panelPrincipal.Controls.Add(buttonVer);
            panelPrincipal.Controls.Add(textBoxNum);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(labeltitulo);
            panelPrincipal.Location = new Point(-1, 1);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(789, 450);
            panelPrincipal.TabIndex = 0;
            // 
            // richTextBoxResultados
            // 
            richTextBoxResultados.Location = new Point(386, 44);
            richTextBoxResultados.Name = "richTextBoxResultados";
            richTextBoxResultados.Size = new Size(356, 362);
            richTextBoxResultados.TabIndex = 4;
            richTextBoxResultados.Text = "";
            // 
            // buttonVer
            // 
            buttonVer.Location = new Point(124, 222);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(94, 29);
            buttonVer.TabIndex = 3;
            buttonVer.Text = "Ver Tabla";
            buttonVer.UseVisualStyleBackColor = true;
            buttonVer.Click += buttonVer_Click;
            // 
            // textBoxNum
            // 
            textBoxNum.Location = new Point(105, 174);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(125, 27);
            textBoxNum.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 127);
            label1.Name = "label1";
            label1.Size = new Size(196, 28);
            label1.TabIndex = 1;
            label1.Text = "¿Cuál tabla quieres?";
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeltitulo.ForeColor = SystemColors.ButtonHighlight;
            labeltitulo.Location = new Point(42, 33);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(275, 39);
            labeltitulo.TabIndex = 0;
            labeltitulo.Text = "Tabla de Multiplicar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 90);
            label2.Name = "label2";
            label2.Size = new Size(311, 24);
            label2.TabIndex = 5;
            label2.Text = "Alumna: Ana Lorena Rosales Delgado";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPrincipal);
            Name = "Form1";
            Text = "Form1";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label labeltitulo;
        private Label label1;
        private RichTextBox richTextBoxResultados;
        private Button buttonVer;
        private TextBox textBoxNum;
        private Label label2;
    }
}
