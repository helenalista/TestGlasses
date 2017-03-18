using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace testglasses
{
    public class sistema
    {
        private void button1_Click(object sender, EventArgs e)        
{
/*A variável strcon é o connection string que copiamos anteriormente enquanto criávamos o banco de dados, essa variável poderia ser utilizada para todos os botões do programa, mas irei repeti-la várias vezes para fixar a idéia dos passos que precisamos seguir para fazer a conexão com o banco, Obs.: note que o caminho do seu banco precisa estar com “\\” se não estiver coloque */
string strcon = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Documents and Settings\\k\\Meus documentos\\banco_dados.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
SqlConnection conexao = new SqlConnection(strcon); /* conexao irá conectar o C# ao banco de dados */
SqlCommand cmd = new SqlCommand("SELECT * FROM tabela", conexao); /*cmd possui mais de um parâmetro, neste caso coloquei o comando SQL "SELECT * FROM tabela" que irá selecionar tudo(*) de tabela, o segundo parâmetro indica onde o banco está conectado,ou seja se estamos selecionando informações do banco precisamos dizer onde ele está localizado */
            Try //Tenta executar o que estiver abaixo
            {                                                                                                                  
                conexao.Open(); // abre a conexão com o banco   
                cmd.ExecuteNonQuery(); // executa cmd
/*Pronto após o cmd.ExecuteNonQuery(); selecionamos tudo o que tinha dentro do banco, agora os passos seguintes irão exibir as informações para que o usuário possa vê-las    */                                                   SqlDataAdapter da = new SqlDataAdapter(); /* da, adapta o banco de dados ao nosso projeto */
                DataSet ds = new DataSet();
                da.SelectCommand = cmd; // adapta cmd ao projeto
                da.Fill(ds); // preenche todas as informações dentro do DataSet                                          
                dataGridView1.DataSource = ds; //Datagridview recebe ds já preenchido
                dataGridView1.DataMember = ds.Tables[0].TableName;  /*Agora Datagridview exibe o banco de dados*/               
            }
            catch (Exception ex)
            {                 
                MessageBox.Show("Erro "+ex.Message); /*Se ocorer algum erro será informado em um msgbox*/
                throw;      
            }
 
            finally
            {         
               conexao.Close(); /* Se tudo ocorrer bem fecha a conexão com o banco da dados, sempre é bom fechar a conexão após executar até o final o que nos interessa, isso pode evitar problemas futuros */
            }
}
    }
}

private void button2_Click(object sender, EventArgs e)   
{
Form2 f = new Form2(); //instância de Form2                      
f.Show(); //abre o Form2
}
private void button3_Click(object sender, EventArgs e)  
{
dataGridView1.Columns.Clear(); //apenas limpa o DataGridView
}

private void button1_Click(object sender, EventArgs e)                                   {
string strcon = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Documents and Settings\\k\\Meus documentos\\Visual Studio 2005\\Projects\\conect_sql_server\\conect_sql_server\\banco_dados.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";            
SqlConnection conexao = new SqlConnection(strcon);
SqlCommand cmd = new SqlCommand("INSERT INTO tabela(nome,numero) VALUES('" + textBox1.Text + "'," + textBox2.Text.Replace(",", ".") + ")", conexao); /* Insere no banco dentro de tabela nos campos nome e número os valores de textBox1 e 4, é necessário colocar o replace no texBox4, pois se o numero tiver "," não irá inserir no banco de dados, a "," representa o próximo campo nessa sintaxe, experimente deixar sem o replace para ver o que acontece
Obs. quando estamos inserindo, deletando, ou alterando um valor no banco de dados, é importante notar que o textbox1 está entre ‘””’ pois essa é sintaxe que usamos quando o valor é uma string, note também que o texbox2 está entre ”” apenas, pois o valor é numérico, nesse caso do tipo float            */     
                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                    button2_Click(sender, e);
/* chama o evento do click do button2 (na verdade é como se o button2 tivesse sido clicado, ou botão select do form2)sempre que quiser fazer com que ocorra um evento sem que o usuário tenha feito, é só passar o comando acima (se tiver duvida dê com copiar no "private void button2_Click(object sender, EventArgs e)" e deixe do jeito que eu modifiquei) o evento que ocorre quando clicamos no button2 é aquele que busca as informações no banco de dados e depois preenche o DataGridView com elas, ao usar button2_Click(sender, e); estamos fazendo com que aconteça exatamente isso, ao clicarmos no botão Insert ou Delete vai parecer q o campo inserido ou deletado no datagridview foi inserido ou deletado na mesma hora. Experimente comentar a linha button2_Click(sender, e); para ver a diferença. */
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro " + ex.Message);
                    throw;
                }
                finally
                {
                    conexao.Close();
                }     
}

private void button2_Click(object sender, EventArgs e)     
{
string strcon = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Documents and Settings\\k\\Meus documentos\\Visual Studio 2005\\Projects\\conect_sql_server\\conect_sql_server\\banco_dados.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
SqlConnection conexao = new SqlConnection(strcon);
SqlCommand cmd = new SqlCommand("SELECT * FROM tabela", conexao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = ds.Tables[0].TableName;
             }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
                throw;
            }
            finally
            {
                conexao.Close();
            }
}

private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {          
 textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
/* ao clicar em uma linha do datagridview, o conteudo é transferido para o texbox 3,4,5 e 6 */
 textBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); //
/* os números [0] e [1] representam o índice da coluna que será transferido para o texbox, nesse caso o texbox4 recebe a coluna [1], texbox5 recebe a coluna [0] */
 textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
 textBox6.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
}

private void button3_Click(object sender, EventArgs e)                                   {
string strcon = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Documents and Settings\\k\\Meus documentos\\Visual Studio 2005\\Projects\\conect_sql_server\\conect_sql_server\\banco_dados.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
SqlConnection conexao = new SqlConnection(strcon);
//SqlCommand cmd = new SqlCommand( ("DELETE FROM tabela WHERE nome= '"+textBox3.Text+"' "),  conexao);
SqlCommand cmd = new SqlCommand( ("DELETE FROM tabela WHERE nome='"+textBox3.Text+"'  AND numero="+textBox4.Text.Replace(",",".")+"    "), conexao); /* é necessário colocar o replace no texbox 4, pois se o numero tiver "," não irá deletar do banco de dados, a "," representa o próximo campo nessa sintaxe, e não queremos isso, apenas queremos deletar o número q possui "," */
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // deleta valores do banco de dados
                button2_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
                throw;
            }
            finally
            {
                conexao.Close();
            }
}