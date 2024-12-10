﻿namespace FashionDesk
{
    partial class FrmConsultaAgendamento
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtConsultar = new Guna.UI2.WinForms.Guna2TextBox();
            lblPesquisa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgvConsultaAgendamento = new Guna.UI2.WinForms.Guna2DataGridView();
            btnfecharForm = new Guna.UI2.WinForms.Guna2ControlBox();
            clnID = new DataGridViewTextBoxColumn();
            clnData = new DataGridViewTextBoxColumn();
            clnHora = new DataGridViewTextBoxColumn();
            clnNomeCliente = new DataGridViewTextBoxColumn();
            clnNomeFuncionario = new DataGridViewTextBoxColumn();
            clnProcedimento = new DataGridViewTextBoxColumn();
            clnStatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaAgendamento).BeginInit();
            SuspendLayout();
            // 
            // txtConsultar
            // 
            txtConsultar.BackgroundImageLayout = ImageLayout.Zoom;
            txtConsultar.CustomizableEdges = customizableEdges1;
            txtConsultar.DefaultText = "";
            txtConsultar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtConsultar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtConsultar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtConsultar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtConsultar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConsultar.Font = new Font("Segoe UI", 9F);
            txtConsultar.ForeColor = Color.Black;
            txtConsultar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConsultar.IconLeft = Properties.Resources.pesquisa;
            txtConsultar.Location = new Point(12, 77);
            txtConsultar.Margin = new Padding(3, 4, 3, 4);
            txtConsultar.Name = "txtConsultar";
            txtConsultar.PasswordChar = '\0';
            txtConsultar.PlaceholderText = "";
            txtConsultar.SelectedText = "";
            txtConsultar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtConsultar.Size = new Size(776, 30);
            txtConsultar.TabIndex = 42;
            txtConsultar.TextChanged += txtConsultar_TextChanged;
            // 
            // lblPesquisa
            // 
            lblPesquisa.BackColor = Color.Transparent;
            lblPesquisa.Location = new Point(13, 60);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(53, 17);
            lblPesquisa.TabIndex = 41;
            lblPesquisa.Text = "Pesquisar";
            // 
            // dgvConsultaAgendamento
            // 
            dgvConsultaAgendamento.AllowUserToAddRows = false;
            dgvConsultaAgendamento.AllowUserToDeleteRows = false;
            dgvConsultaAgendamento.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvConsultaAgendamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvConsultaAgendamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvConsultaAgendamento.ColumnHeadersHeight = 17;
            dgvConsultaAgendamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvConsultaAgendamento.Columns.AddRange(new DataGridViewColumn[] { clnID, clnData, clnHora, clnNomeCliente, clnNomeFuncionario, clnProcedimento, clnStatus });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvConsultaAgendamento.DefaultCellStyle = dataGridViewCellStyle3;
            dgvConsultaAgendamento.GridColor = Color.FromArgb(231, 229, 255);
            dgvConsultaAgendamento.Location = new Point(13, 114);
            dgvConsultaAgendamento.Name = "dgvConsultaAgendamento";
            dgvConsultaAgendamento.ReadOnly = true;
            dgvConsultaAgendamento.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvConsultaAgendamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvConsultaAgendamento.RowHeadersVisible = false;
            dgvConsultaAgendamento.Size = new Size(775, 332);
            dgvConsultaAgendamento.TabIndex = 43;
            dgvConsultaAgendamento.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvConsultaAgendamento.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F);
            dgvConsultaAgendamento.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.FromArgb(255, 128, 255);
            dgvConsultaAgendamento.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvConsultaAgendamento.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvConsultaAgendamento.ThemeStyle.BackColor = Color.White;
            dgvConsultaAgendamento.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvConsultaAgendamento.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvConsultaAgendamento.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvConsultaAgendamento.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvConsultaAgendamento.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvConsultaAgendamento.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvConsultaAgendamento.ThemeStyle.HeaderStyle.Height = 17;
            dgvConsultaAgendamento.ThemeStyle.ReadOnly = true;
            dgvConsultaAgendamento.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvConsultaAgendamento.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvConsultaAgendamento.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvConsultaAgendamento.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvConsultaAgendamento.ThemeStyle.RowsStyle.Height = 25;
            dgvConsultaAgendamento.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvConsultaAgendamento.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // btnfecharForm
            // 
            btnfecharForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnfecharForm.CustomizableEdges = customizableEdges3;
            btnfecharForm.FillColor = Color.FromArgb(139, 152, 166);
            btnfecharForm.IconColor = Color.White;
            btnfecharForm.Location = new Point(756, -1);
            btnfecharForm.Name = "btnfecharForm";
            btnfecharForm.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnfecharForm.Size = new Size(44, 24);
            btnfecharForm.TabIndex = 44;
            btnfecharForm.Click += btnfecharForm_Click;
            // 
            // clnID
            // 
            clnID.HeaderText = "ID";
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            // 
            // clnData
            // 
            clnData.HeaderText = "Data";
            clnData.Name = "clnData";
            clnData.ReadOnly = true;
            // 
            // clnHora
            // 
            clnHora.HeaderText = "Hora";
            clnHora.Name = "clnHora";
            clnHora.ReadOnly = true;
            // 
            // clnNomeCliente
            // 
            clnNomeCliente.HeaderText = "Nome do Cliente";
            clnNomeCliente.Name = "clnNomeCliente";
            clnNomeCliente.ReadOnly = true;
            // 
            // clnNomeFuncionario
            // 
            clnNomeFuncionario.HeaderText = "Nome do Funcionario";
            clnNomeFuncionario.Name = "clnNomeFuncionario";
            clnNomeFuncionario.ReadOnly = true;
            // 
            // clnProcedimento
            // 
            clnProcedimento.HeaderText = "Procedimento";
            clnProcedimento.Name = "clnProcedimento";
            clnProcedimento.ReadOnly = true;
            // 
            // clnStatus
            // 
            clnStatus.HeaderText = "Status";
            clnStatus.Name = "clnStatus";
            clnStatus.ReadOnly = true;
            // 
            // FrmConsultaAgendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnfecharForm);
            Controls.Add(dgvConsultaAgendamento);
            Controls.Add(txtConsultar);
            Controls.Add(lblPesquisa);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConsultaAgendamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultaAgendamento";
            Load += FrmConsultaAgendamento_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultaAgendamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtConsultar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPesquisa;
        private Guna.UI2.WinForms.Guna2DataGridView dgvConsultaAgendamento;
        private Guna.UI2.WinForms.Guna2ControlBox btnfecharForm;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnData;
        private DataGridViewTextBoxColumn clnHora;
        private DataGridViewTextBoxColumn clnNomeCliente;
        private DataGridViewTextBoxColumn clnNomeFuncionario;
        private DataGridViewTextBoxColumn clnProcedimento;
        private DataGridViewTextBoxColumn clnStatus;
    }
}