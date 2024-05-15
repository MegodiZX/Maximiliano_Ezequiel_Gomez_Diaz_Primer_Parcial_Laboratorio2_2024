namespace Gomez_Diaz.Maximiliano_Ezequiel.A23
{
    partial class FrmAtencion
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
            lbl_Medicos = new Label();
            lbl_Pacientes = new Label();
            btn_Atender = new Button();
            lst_Medicos = new ListBox();
            lst_Pacientes = new ListBox();
            btn_Salir = new Button();
            rtb_InfoMedico = new RichTextBox();
            SuspendLayout();
            // 
            // lbl_Medicos
            // 
            lbl_Medicos.AutoSize = true;
            lbl_Medicos.Location = new Point(46, 25);
            lbl_Medicos.Name = "lbl_Medicos";
            lbl_Medicos.Size = new Size(95, 15);
            lbl_Medicos.TabIndex = 0;
            lbl_Medicos.Text = "Personal Medico";
            // 
            // lbl_Pacientes
            // 
            lbl_Pacientes.AutoSize = true;
            lbl_Pacientes.Location = new Point(316, 25);
            lbl_Pacientes.Name = "lbl_Pacientes";
            lbl_Pacientes.Size = new Size(57, 15);
            lbl_Pacientes.TabIndex = 1;
            lbl_Pacientes.Text = "Pacientes";
            // 
            // btn_Atender
            // 
            btn_Atender.Location = new Point(564, 70);
            btn_Atender.Name = "btn_Atender";
            btn_Atender.Size = new Size(154, 63);
            btn_Atender.TabIndex = 2;
            btn_Atender.Text = "Atender";
            btn_Atender.UseVisualStyleBackColor = true;
            btn_Atender.Click += button1_Click;
            // 
            // lst_Medicos
            // 
            lst_Medicos.FormattingEnabled = true;
            lst_Medicos.ItemHeight = 15;
            lst_Medicos.Location = new Point(47, 70);
            lst_Medicos.Name = "lst_Medicos";
            lst_Medicos.Size = new Size(170, 139);
            lst_Medicos.TabIndex = 4;
            lst_Medicos.SelectedIndexChanged += lst_Medicos_SelectedIndexChanged;
            // 
            // lst_Pacientes
            // 
            lst_Pacientes.FormattingEnabled = true;
            lst_Pacientes.ItemHeight = 15;
            lst_Pacientes.Location = new Point(316, 70);
            lst_Pacientes.Name = "lst_Pacientes";
            lst_Pacientes.Size = new Size(170, 139);
            lst_Pacientes.TabIndex = 7;
            // 
            // btn_Salir
            // 
            btn_Salir.Location = new Point(564, 290);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(154, 63);
            btn_Salir.TabIndex = 8;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // rtb_InfoMedico
            // 
            rtb_InfoMedico.Location = new Point(46, 236);
            rtb_InfoMedico.Name = "rtb_InfoMedico";
            rtb_InfoMedico.Size = new Size(440, 117);
            rtb_InfoMedico.TabIndex = 9;
            rtb_InfoMedico.Text = "";
            // 
            // FrmAtencion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 387);
            Controls.Add(rtb_InfoMedico);
            Controls.Add(btn_Salir);
            Controls.Add(lst_Pacientes);
            Controls.Add(lst_Medicos);
            Controls.Add(btn_Atender);
            Controls.Add(lbl_Pacientes);
            Controls.Add(lbl_Medicos);
            Name = "FrmAtencion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gomez.Diaz_Maximiliano.Ezequiel";
            Load += FrmAtencion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Medicos;
        private Label lbl_Pacientes;
        private Button btn_Atender;
        private ListBox lst_Medicos;
        private ListBox lst_Pacientes;
        private Button btn_Salir;
        private RichTextBox rtb_InfoMedico;
    }
}
