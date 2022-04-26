using System;
using System.Drawing;
using System.Windows.Forms;

namespace HandRanges
{
    public partial class HandRanges : Form
    {
        bool clickBB = false;
        bool clickUTG = false;
        bool clickUTG1 = false;
        bool clickMP1 = false;
        bool clickMP2 = false;
        bool clickHJ = false;
        bool clickCO = false;
        bool clickBTN = false;
        bool clickSB = false;

        public HandRanges()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guiaPrincipal.IsAccessible = false;
        }

        // Trata o background dos botões quando o mouse estiver sobre eles.
        #region MouseEnter
        private void btBB_MouseEnter(object sender, EventArgs e)
        {
            if (clickBB == false)
                btBB.BackColor = Color.FromArgb(173, 255, 47);// Mudando a cor de fundo do botão para GreenYellow
        }

        private void btUTG_MouseEnter(object sender, EventArgs e)
        {
            if (clickUTG == false)
                btUTG.BackColor = Color.FromArgb(173, 255, 47);// Mudando a cor de fundo do botão para GreenYellow
        }
        private void btUTG1_MouseEnter(object sender, EventArgs e)
        {
            if (clickUTG1 == false)
                btUTG1.BackColor = Color.FromArgb(173, 255, 47);// Mudando a cor de fundo do botão para GreenYellow
        }

        private void btMP1_MouseEnter(object sender, EventArgs e)
        {
            if (clickMP1 == false)
                btMP1.BackColor = Color.FromArgb(173, 255, 47);// Mudando a cor de fundo do botão para GreenYellow
        }

        private void btMP2_MouseEnter(object sender, EventArgs e)
        {
            if (clickMP2 == false)
                btMP2.BackColor = Color.FromArgb(173, 255, 47);// Mudando a cor de fundo do botão para GreenYellow
        }

        private void btHJ_MouseEnter(object sender, EventArgs e)
        {
            if (clickHJ == false)
                btHJ.BackColor = Color.FromArgb(173, 255, 47);// Mudando a cor de fundo do botão para GreenYellow
        }

        private void btCO_MouseEnter(object sender, EventArgs e)
        {
            if (clickCO == false)
                btCO.BackColor = Color.FromArgb(173, 255, 47);// Mudando a cor de fundo do botão para GreenYellow
        }

        private void btBTN_MouseEnter(object sender, EventArgs e)
        {
            if (clickBTN == false)
                btBTN.BackColor = Color.FromArgb(173, 255, 47);// Mudando a cor de fundo do botão para GreenYellow
        }

        private void btSB_MouseEnter(object sender, EventArgs e)
        {
            if (clickSB == false)
                btSB.BackColor = Color.FromArgb(173, 255, 47);// Mudando a cor de fundo do botão para GreenYellow
        }
        #endregion MouseEnter

        // Trata o background dos botões quando o mouse estiver fora deles.
        #region MouseLeave
        private void btBB_MouseLeave(object sender, EventArgs e)
        {
            if (clickBB == false)
                btBB.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
        }

        private void btUTG_MouseLeave(object sender, EventArgs e)
        {
            if (clickUTG == false)
                btUTG.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
        }

        private void btUTG1_MouseLeave(object sender, EventArgs e)
        {
            if (clickUTG1 == false)
                btUTG1.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
        }

        private void btMP1_MouseLeave(object sender, EventArgs e)
        {
            if (clickMP1 == false)
                btMP1.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
        }

        private void btMP2_MouseLeave(object sender, EventArgs e)
        {
            if (clickMP2 == false)
                btMP2.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
        }

        private void btHJ_MouseLeave(object sender, EventArgs e)
        {
            if (clickHJ == false)
                btHJ.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
        }

        private void btCO_MouseLeave(object sender, EventArgs e)
        {
            if (clickCO == false)
                btCO.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
        }

        private void btBTN_MouseLeave(object sender, EventArgs e)
        {
            if (clickBTN == false)
                btBTN.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
        }

        private void btSB_MouseLeave(object sender, EventArgs e)
        {
            if (clickSB == false)
                btSB.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
        }
        #endregion MouseLeave

        // Trata as ações a serem tomadas quando um botão for clicado.
        #region Click

        private void btBB_Click(object sender, EventArgs e)
        {
            btBB.BackColor = Color.FromArgb(0, 255, 0);// Mudando a cor de fundo do botão para Lime
            clickBB = !clickBB;

            btUTG.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btUTG1.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btMP1.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btMP2.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btHJ.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btCO.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btBTN.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btSB.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue

            clickUTG = false;
            clickUTG1 = false;
            clickMP1 = false;
            clickMP2 = false;
            clickHJ = false;
            clickCO = false;
            clickBTN = false;
            clickSB = false;
        }

        private void btUTG_Click(object sender, EventArgs e)
        {
            btUTG.BackColor = Color.FromArgb(0, 255, 0);// Mudando a cor de fundo do botão para Lime
            clickUTG = !clickUTG;

            btBB.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btUTG1.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btMP1.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btMP2.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btHJ.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btCO.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btBTN.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btSB.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue

            clickBB = false;
            clickUTG1 = false;
            clickMP1 = false;
            clickMP2 = false;
            clickHJ = false;
            clickCO = false;
            clickBTN = false;
            clickSB = false;
        }

        private void btUTG1_Click(object sender, EventArgs e)
        {
            btUTG1.BackColor = Color.FromArgb(0, 255, 0);// Mudando a cor de fundo do botão para Lime
            clickUTG1 = !clickUTG1;

            btBB.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btUTG.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btMP1.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btMP2.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btHJ.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btCO.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btBTN.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btSB.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue

            clickBB = false;
            clickUTG = false;
            clickMP1 = false;
            clickMP2 = false;
            clickHJ = false;
            clickCO = false;
            clickBTN = false;
            clickSB = false;
        }

        private void btMP1_Click(object sender, EventArgs e)
        {
            btMP1.BackColor = Color.FromArgb(0, 255, 0);// Mudando a cor de fundo do botão para Lime
            clickMP1 = !clickMP1;

            btBB.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btUTG.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btUTG1.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btMP2.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btHJ.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btCO.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btBTN.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btSB.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue

            clickBB = false;
            clickUTG = false;
            clickUTG1 = false;
            clickMP2 = false;
            clickHJ = false;
            clickCO = false;
            clickBTN = false;
            clickSB = false;
        }

        private void btMP2_Click(object sender, EventArgs e)
        {
            btMP2.BackColor = Color.FromArgb(0, 255, 0);// Mudando a cor de fundo do botão para Lime
            clickMP2 = !clickMP2;

            btBB.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btUTG.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btUTG1.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btMP1.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btHJ.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btCO.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btBTN.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btSB.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue

            clickBB = false;
            clickUTG = false;
            clickUTG1 = false;
            clickMP1 = false;
            clickHJ = false;
            clickCO = false;
            clickBTN = false;
            clickSB = false;
        }

        private void btHJ_Click(object sender, EventArgs e)
        {
            btHJ.BackColor = Color.FromArgb(0, 255, 0);// Mudando a cor de fundo do botão para Lime
            clickHJ = !clickHJ;

            btBB.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btUTG.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btUTG1.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btMP1.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btMP2.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btCO.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btBTN.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btSB.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue

            clickBB = false;
            clickUTG = false;
            clickUTG1 = false;
            clickMP1 = false;
            clickMP2 = false;
            clickCO = false;
            clickBTN = false;
            clickSB = false;
        }

        private void btCO_Click(object sender, EventArgs e)
        {
            btCO.BackColor = Color.FromArgb(0, 255, 0);// Mudando a cor de fundo do botão para Lime
            clickCO = !clickCO;

            btBB.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btUTG.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btUTG1.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btMP1.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btMP2.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btHJ.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btBTN.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btSB.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue

            clickBB = false;
            clickUTG = false;
            clickUTG1 = false;
            clickMP1 = false;
            clickMP2 = false;
            clickHJ = false;
            clickBTN = false;
            clickSB = false;
        }

        private void btBTN_Click(object sender, EventArgs e)
        {
            btBTN.BackColor = Color.FromArgb(0, 255, 0);// Mudando a cor de fundo do botão para Lime
            clickBTN = !clickBTN;

            btBB.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btUTG.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btUTG1.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btMP1.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btMP2.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btHJ.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btCO.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btSB.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue

            clickBB = false;
            clickUTG = false;
            clickUTG1 = false;
            clickMP1 = false;
            clickMP2 = false;
            clickHJ = false;
            clickCO = false;
            clickSB = false;
        }

        private void btSB_Click(object sender, EventArgs e)
        {
            btSB.BackColor = Color.FromArgb(0, 255, 0);// Mudando a cor de fundo do botão para Lime
            clickSB = !clickSB;

            btBB.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btUTG.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btUTG1.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btMP1.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btMP2.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btHJ.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btCO.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue
            btBTN.BackColor = Color.FromArgb(30, 144, 255);// Mudando a cor de fundo do botão para DodgerBlue

            clickBB = false;
            clickUTG = false;
            clickUTG1 = false;
            clickMP1 = false;
            clickMP2 = false;
            clickHJ = false;
            clickCO = false;
            clickBTN = false;
        }
        #endregion Click
    }
}
