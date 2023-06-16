using System;
using System.Linq;
using System.Windows.Forms;

namespace SeMO1
{
    public partial class GridForm : Form
    {
        public static double L = StartForm.L; // количество систем в сети
        public static double N = StartForm.N; // количество требований в замкнутой сети
        public static int theoremNumb = StartForm.theoremNumb; // номер теоремы
        public static double[] mu = StartForm.mu;

        public GridForm()
        {
            InitializeComponent();
        }

        private void n_i_Click(object sender, EventArgs e) // метод для вычисления n_i|N
        {
            for (int i = 0; i < L; i++)
            {
                this.chart1.Series[i].Points.Clear();
            }

            double res = 0;
            for (int j = 1; j <= L; j++)
            {
                for (int i = 1; i <= N; i++)
                {
                    switch (theoremNumb)
                    {
                        case 1:
                            res = i / L; 
                            break;
                        case 2:
                            res = mu[j - 1] * i / mu.Sum(); 
                            break;
                        case 3:
                            res = (mu[j - 1] * (L + i) - mu.Sum()) / 
                                mu.Sum(); 
                            break;
                    }
                    this.chart1.Series[j - 1].Points.AddXY(i, res);
                }
            }
        }
        private void u_i_Click(object sender, EventArgs e) // метод для вычисления u_i|N
        {
            for (int i = 0; i < L; i++)
            {
                this.chart1.Series[i].Points.Clear();
            }

            double res = 0;
            for (int j = 1; j <= L; j++)
            {
                for (int i = 1; i <= N; i++)
                {
                    switch (theoremNumb)
                    {
                        case 1:
                            res = (L + i - 1) / (mu[j - 1] * L); 
                            break;
                        case 2:
                            res = (mu[j - 1] * (i - 1) + mu.Sum()) / 
                                (mu[j - 1] * mu.Sum()); 
                            break;
                        case 3:
                            res = (L + i - 1) / mu.Sum(); 
                            break;
                    }
                    this.chart1.Series[j - 1].Points.AddXY(i, res);
                }
            }
        }
        private void w_i_Click(object sender, EventArgs e) // метод для вычисления w_i|N
        {
            for (int i = 0; i < L; i++)
            {
                this.chart1.Series[i].Points.Clear();
            }

            double res = 0;
            for (int j = 1; j <= L; j++)
            {
                for (int i = 1; i <= N; i++)
                {
                    switch (theoremNumb)
                    {
                        case 1:
                            res = (i - 1) / (mu[j - 1] * L); 
                            break;
                        case 2:
                            res = (i - 1) / mu.Sum(); 
                            break;
                        case 3:
                            res = (mu[j - 1] * (L + i - 1) - mu.Sum())/ 
                                (mu[j - 1] * mu.Sum()); 
                            break;
                    }
                    this.chart1.Series[j - 1].Points.AddXY(i, res);
                }
            }
        }
        private void lambda_i_Click(object sender, EventArgs e) // метод для вычисления lambda_i|N
        {
            for (int i = 0; i < L; i++)
            {
                this.chart1.Series[i].Points.Clear();
            }

            double res = 0;
            for (int j = 1; j <= L; j++)
            {
                for (int i = 1; i <= N; i++)
                {
                    switch (theoremNumb)
                    {
                        case 1:
                            res = (mu[j - 1] * i) / (L + i - 1); 
                            break;
                        case 2:
                            res = (Math.Pow(mu[j - 1], 2) * i) / 
                                (mu[j - 1] * (i - 1) + mu.Sum()); 
                            break;
                        case 3:
                            res = (mu[j - 1] * (L + i) - mu.Sum()) / 
                                (L + i - 1); 
                            break;
                    }
                    this.chart1.Series[j - 1].Points.AddXY(i, res);
                }
            }
        }
        private void psi_i_Click(object sender, EventArgs e) // метод для вычисления psi_i
        {
            for (int i = 0; i < L; i++)
            {
                this.chart1.Series[i].Points.Clear();
            }

            double res = 0;
            for (int j = 1; j <= L; j++)
            {
                for (int i = 1; i <= N; i++)
                {
                    switch (theoremNumb)
                    {
                        case 1:
                            res = i / (L + i - 1); 
                            break;
                        case 2:
                            res = (mu[j - 1] * i) / 
                                (mu[j - 1] * (i - 1) + mu.Sum()); 
                            break;
                        case 3:
                            res = (mu[j - 1] * (L + i) - mu.Sum()) / 
                                (mu[j - 1] * (L + i - 1)); 
                            break;
                    }
                    this.chart1.Series[j - 1].Points.AddXY(i, res);
                }
            }
        }
        private void q_i_Click(object sender, EventArgs e) // метод для вычисления q_i
        {
            for (int i = 0; i < L; i++)
            {
                this.chart1.Series[i].Points.Clear();
            }

            double res = 0;
            for (int j = 1; j <= L; j++)
            {
                for (int i = 1; i <= N; i++)
                {
                    switch (theoremNumb)
                    {
                        case 1:
                            res = 1.0 / L; 
                            break;
                        case 2: 
                            res = mu[j - 1] / mu.Sum(); 
                            break;
                        case 3:
                            res = (mu[j - 1] * (L + i) - mu.Sum())/ 
                                (i * mu.Sum()); 
                            break;
                    }
                    this.chart1.Series[j - 1].Points.AddXY(i, res);
                }
            }
        }
        private void omega_i_Click(object sender, EventArgs e) // метод для вычисления omega_i
        {
            for (int i = 0; i < L; i++)
            {
                this.chart1.Series[i].Points.Clear();
            }

            double res = 0;
            for (int j = 1; j <= L; j++)
            {
                for (int i = 1; i <= N; i++)
                {
                    switch (theoremNumb)
                    {
                        case 1:
                            res = mu[j - 1] / mu.Sum();
                            break;
                        case 2:
                            double summa = 0;
                            for (int k = 1; k <= L; k++)
                            {
                                summa += (Math.Pow(mu[k - 1], 2)) / 
                                    (mu[k - 1] * (i - 1) + mu.Sum());
                            }
                            res = Math.Pow(mu[j - 1], 2) / 
                                ((mu[j - 1] * (i - 1) + mu.Sum()) * summa);
                            break;
                        case 3:
                            res = (mu[j - 1] * (L + i) - mu.Sum()) / 
                                (i * mu.Sum());
                            break;
                    }
                    this.chart1.Series[j - 1].Points.AddXY(i, res);
                }
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
