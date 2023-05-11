namespace Calculadora_WinApp_versão_1._0
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
            TXTresultado = new TextBox();
            BTNzero = new Button();
            BTNum = new Button();
            BTNdois = new Button();
            BTNtres = new Button();
            BTNquatro = new Button();
            BTNcinco = new Button();
            BTNseis = new Button();
            BTNsete = new Button();
            BTNoito = new Button();
            BTNnove = new Button();
            BTNsubtracao = new Button();
            BTNsoma = new Button();
            BTNdivisao = new Button();
            BTNmultiplicacao = new Button();
            BTNvirgula = new Button();
            BTNigual = new Button();
            BTNlimpar = new Button();
            LBLoperacao = new Label();
            SuspendLayout();
            // 
            // TXTresultado
            // 
            TXTresultado.Location = new Point(12, 12);
            TXTresultado.Name = "TXTresultado";
            TXTresultado.ReadOnly = true;
            TXTresultado.Size = new Size(213, 23);
            TXTresultado.TabIndex = 0;
            TXTresultado.TextAlign = HorizontalAlignment.Right;
            TXTresultado.TextChanged += TXTresultado_TextChanged;
            // 
            // BTNzero
            // 
            BTNzero.Location = new Point(64, 232);
            BTNzero.Name = "BTNzero";
            BTNzero.Size = new Size(46, 39);
            BTNzero.TabIndex = 1;
            BTNzero.Text = "0";
            BTNzero.UseVisualStyleBackColor = true;
            BTNzero.Click += BTNzero_Click;
            // 
            // BTNum
            // 
            BTNum.Location = new Point(12, 187);
            BTNum.Name = "BTNum";
            BTNum.Size = new Size(46, 39);
            BTNum.TabIndex = 2;
            BTNum.Text = "1";
            BTNum.UseVisualStyleBackColor = true;
            BTNum.Click += BTNum_Click;
            // 
            // BTNdois
            // 
            BTNdois.Location = new Point(64, 185);
            BTNdois.Name = "BTNdois";
            BTNdois.Size = new Size(46, 39);
            BTNdois.TabIndex = 3;
            BTNdois.Text = "2";
            BTNdois.UseVisualStyleBackColor = true;
            BTNdois.Click += BTNdois_Click;
            // 
            // BTNtres
            // 
            BTNtres.Location = new Point(116, 185);
            BTNtres.Name = "BTNtres";
            BTNtres.Size = new Size(46, 39);
            BTNtres.TabIndex = 4;
            BTNtres.Text = "3";
            BTNtres.UseVisualStyleBackColor = true;
            BTNtres.Click += BTNtres_Click;
            // 
            // BTNquatro
            // 
            BTNquatro.Location = new Point(12, 140);
            BTNquatro.Name = "BTNquatro";
            BTNquatro.Size = new Size(46, 39);
            BTNquatro.TabIndex = 5;
            BTNquatro.Text = "4";
            BTNquatro.UseVisualStyleBackColor = true;
            BTNquatro.Click += BTNquatro_Click;
            // 
            // BTNcinco
            // 
            BTNcinco.Location = new Point(64, 140);
            BTNcinco.Name = "BTNcinco";
            BTNcinco.Size = new Size(46, 39);
            BTNcinco.TabIndex = 6;
            BTNcinco.Text = "5";
            BTNcinco.UseVisualStyleBackColor = true;
            BTNcinco.Click += button6_Click;
            // 
            // BTNseis
            // 
            BTNseis.Location = new Point(116, 140);
            BTNseis.Name = "BTNseis";
            BTNseis.Size = new Size(46, 39);
            BTNseis.TabIndex = 7;
            BTNseis.Text = "6";
            BTNseis.UseVisualStyleBackColor = true;
            BTNseis.Click += BTNseis_Click;
            // 
            // BTNsete
            // 
            BTNsete.Location = new Point(12, 95);
            BTNsete.Name = "BTNsete";
            BTNsete.Size = new Size(46, 39);
            BTNsete.TabIndex = 8;
            BTNsete.Text = "7";
            BTNsete.UseVisualStyleBackColor = true;
            BTNsete.Click += button8_Click;
            // 
            // BTNoito
            // 
            BTNoito.Location = new Point(64, 95);
            BTNoito.Name = "BTNoito";
            BTNoito.Size = new Size(46, 39);
            BTNoito.TabIndex = 9;
            BTNoito.Text = "8";
            BTNoito.UseVisualStyleBackColor = true;
            BTNoito.Click += BTNoito_Click;
            // 
            // BTNnove
            // 
            BTNnove.Location = new Point(116, 95);
            BTNnove.Name = "BTNnove";
            BTNnove.Size = new Size(46, 39);
            BTNnove.TabIndex = 10;
            BTNnove.Text = "9";
            BTNnove.UseVisualStyleBackColor = true;
            BTNnove.Click += BTNnove_Click;
            // 
            // BTNsubtracao
            // 
            BTNsubtracao.Location = new Point(179, 185);
            BTNsubtracao.Name = "BTNsubtracao";
            BTNsubtracao.Size = new Size(46, 39);
            BTNsubtracao.TabIndex = 11;
            BTNsubtracao.Text = "-";
            BTNsubtracao.UseVisualStyleBackColor = true;
            BTNsubtracao.Click += BTNsubtracao_Click;
            // 
            // BTNsoma
            // 
            BTNsoma.Location = new Point(179, 230);
            BTNsoma.Name = "BTNsoma";
            BTNsoma.Size = new Size(46, 39);
            BTNsoma.TabIndex = 12;
            BTNsoma.Text = "+";
            BTNsoma.UseVisualStyleBackColor = true;
            BTNsoma.Click += BTNsoma_Click;
            // 
            // BTNdivisao
            // 
            BTNdivisao.Location = new Point(179, 95);
            BTNdivisao.Name = "BTNdivisao";
            BTNdivisao.Size = new Size(46, 39);
            BTNdivisao.TabIndex = 13;
            BTNdivisao.Text = "/";
            BTNdivisao.UseVisualStyleBackColor = true;
            BTNdivisao.Click += BTNdivisao_Click;
            // 
            // BTNmultiplicacao
            // 
            BTNmultiplicacao.Location = new Point(179, 140);
            BTNmultiplicacao.Name = "BTNmultiplicacao";
            BTNmultiplicacao.Size = new Size(46, 39);
            BTNmultiplicacao.TabIndex = 14;
            BTNmultiplicacao.Text = "*";
            BTNmultiplicacao.UseVisualStyleBackColor = true;
            BTNmultiplicacao.Click += button14_Click;
            // 
            // BTNvirgula
            // 
            BTNvirgula.Location = new Point(12, 232);
            BTNvirgula.Name = "BTNvirgula";
            BTNvirgula.Size = new Size(46, 39);
            BTNvirgula.TabIndex = 15;
            BTNvirgula.Text = ",";
            BTNvirgula.UseVisualStyleBackColor = true;
            BTNvirgula.Click += BTNvirgula_Click;
            // 
            // BTNigual
            // 
            BTNigual.Location = new Point(116, 230);
            BTNigual.Name = "BTNigual";
            BTNigual.Size = new Size(46, 39);
            BTNigual.TabIndex = 16;
            BTNigual.Text = "=";
            BTNigual.UseVisualStyleBackColor = true;
            BTNigual.Click += BTNigual_Click;
            // 
            // BTNlimpar
            // 
            BTNlimpar.Location = new Point(179, 62);
            BTNlimpar.Name = "BTNlimpar";
            BTNlimpar.Size = new Size(46, 27);
            BTNlimpar.TabIndex = 17;
            BTNlimpar.Text = "C";
            BTNlimpar.UseVisualStyleBackColor = true;
            BTNlimpar.Click += BTNlimpar_Click;
            // 
            // LBLoperacao
            // 
            LBLoperacao.AutoSize = true;
            LBLoperacao.Location = new Point(20, 15);
            LBLoperacao.Name = "LBLoperacao";
            LBLoperacao.Size = new Size(0, 15);
            LBLoperacao.TabIndex = 18;
            LBLoperacao.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 303);
            Controls.Add(LBLoperacao);
            Controls.Add(BTNlimpar);
            Controls.Add(BTNigual);
            Controls.Add(BTNvirgula);
            Controls.Add(BTNmultiplicacao);
            Controls.Add(BTNdivisao);
            Controls.Add(BTNsoma);
            Controls.Add(BTNsubtracao);
            Controls.Add(BTNnove);
            Controls.Add(BTNoito);
            Controls.Add(BTNsete);
            Controls.Add(BTNseis);
            Controls.Add(BTNcinco);
            Controls.Add(BTNquatro);
            Controls.Add(BTNtres);
            Controls.Add(BTNdois);
            Controls.Add(BTNum);
            Controls.Add(BTNzero);
            Controls.Add(TXTresultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXTresultado;
        private Button BTNzero;
        private Button BTNum;
        private Button BTNdois;
        private Button BTNtres;
        private Button BTNquatro;
        private Button BTNcinco;
        private Button BTNseis;
        private Button BTNsete;
        private Button BTNoito;
        private Button BTNnove;
        private Button BTNsubtracao;
        private Button BTNsoma;
        private Button BTNdivisao;
        private Button BTNmultiplicacao;
        private Button BTNvirgula;
        private Button BTNigual;
        private Button BTNlimpar;
        private Label LBLoperacao;
    }
}