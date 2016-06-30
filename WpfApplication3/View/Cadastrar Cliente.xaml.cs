using BiblioPeka.DAL;
using BiblioPeka.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication3.View
{
    /// <summary>
    /// Interaction logic for Cadastrar_Cliente.xaml
    /// </summary>
    public partial class Cadastrar_Cliente : Window
    {

        private Pessoa p = new Pessoa();

        public Cadastrar_Cliente()
        {
            InitializeComponent();
        }

        private void btn_Incluir_Click(object sender, RoutedEventArgs e)
        {
            p = new Pessoa();
            p.Nome = txt_Nome.Text;
            p.CPF = txt_CPF.Text;

            if (PessoaDAO.AlterarPessoa(p))
            {
                MessageBox.Show("Gravado com sucesso!", "Cadastro de Pessoa",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Não foi possível gravar!", "Cadastro de Pessoa",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }

            txt_Nome.Text = "";
            txt_Nome.Focus();
        }
    }
}
