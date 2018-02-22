using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ND.MODAL;
using ND.BLL;
using ND.BLL.Exceptions;
using ND.BLL.Sistema;

using System.Data;

namespace ND
{
    public partial class Default : System.Web.UI.Page
    {



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                carregarBairro();
                carregarGrupo();
            }
        }

        //metodo para preencher os dropDawn
        private void carregarBairro() 
        {
            var _bairroBLL = new bairroBLL();
            dpBairro.DataSource = _bairroBLL.listarTodosBairros();
            dpBairro.DataBind(); 

        }
        private void carregarGrupo()
        {
            var _grupoBLL = new grupoBLL();
            dpGrupo.DataSource = _grupoBLL.listarTodosGrupos();
            dpGrupo.DataBind();

        }

        private void Clean() 
        {
            txtFirstNome.Text = "";
            dpGrupo.SelectedIndex = -1;
            dpBairro.SelectedIndex = -1;
            txtEndereco.Text = "";
            txtLograduro.Text = "";
            txtNumero.Text = "";
            TextNum1.Text = "";
            TextNum2.Text = "";
            TextNum3.Text = "";
            txtResidencial.Text = "";
            txtCom1.Text = "";
            txtCom2.Text = "";  
            txtEmail.Text= "";
            txtSite.Text = "";


        }


        protected void btnCadastra_Click(object sender, EventArgs e)
        {
             var c = new contatos();

            try
            {
                try
                {
                    c.nome = Convert.ToString(txtFirstNome.Text);
                    c.idGrupo = Convert.ToInt32(dpGrupo.SelectedValue);
                    c.endereco = Convert.ToString(txtEndereco.Text);
                    c.lograduro = Convert.ToString(txtLograduro.Text);
                    c.numero = Convert.ToInt32(txtNumero.Text);
                    c.complemento = Convert.ToString(txtComplemento.Text);
                    c.idBairro =  Convert.ToInt32(dpBairro.SelectedValue);
                    c.celular1 = Convert.ToString(TextNum1.Text);
                    c.celular2 = Convert.ToString(TextNum2.Text);
                    c.celular3 = Convert.ToString(TextNum3.Text);
                    c.residencial = Convert.ToString(txtResidencial.Text); 
                    c.comercial1 = Convert.ToString(txtCom1.Text); 
                    c.comercial2 = Convert.ToString(txtCom2.Text);
                    c.email = Convert.ToString(txtEmail.Text);
                    c.site = Convert.ToString(txtSite.Text);


                    var contBLL = new contatoBLL();

                    contBLL.inserirContato(c);

                    lblSuccess.Text = "Aluno Cadastrado com sucesso!";
                    Clean(); 

                }
                catch (contatoNaoCadastradoExceptions)
                { 
                    lblAttencion.Text = "Erro no preenchimento dos Campos!";
                }


            }catch(contatoInvalidoExceptions){
                lblDanger.Text = "Erro ao Cadastrar o Aluno!";
            }
            

        }





        }
       

        
    }
