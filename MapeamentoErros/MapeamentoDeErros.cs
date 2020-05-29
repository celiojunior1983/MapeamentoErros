using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapeamentoErros
{
    public static class MapeamentoDeErros
    {
        public static string MensagensDeErro(string mensagem)
        {
            try
            {
                switch (mensagem)
                {
                    case "10.50.1617":
                        return "Essa versão é incompatível com este servidor, favor verificar.";
                    case "Failed to connect to server ..":
                        return "Falha ao conectar ao servidor.";
                    case "Invalid username or password":
                        return "Favor verificar os dados de acesso: usuário e senha.";
                    case "Object reference not set to an instance of an object.":
                        return "Sem retorno na consulta, verificar a conexão com o banco de dados.";
                    case "Input string was not in a correct format.":
                        return "Variável do sistema com formato incorreto, favor detalhar a rotina e os dados inseridos para Informática.";
                    case "Value was either too large or too small for an Int32.":
                        return "Conversão errada de variável, favor detalhar a rotina e os dados inseridos para Informática.";
                    case "Erro ao converter tipo de dados bigint em int":
                        return "Erro de tipos de conversão entre aplicação e banco, favor detalhar a rotina e os dados inseridos para Informática.";
                    case "Tempo Limite de Execução Expirado.  O período de tempo limite terminou antes da conclusão da operação ou o servidor não está respondendo.":
                        return "Lentidão na rede, existem processos pesados impedindo a comunicação entre os computadores.";
                    case "Não há linha na posição 0.":
                        return "Uma consulta no sistema não retornou valor, causando erro no DataSet. Favor informar a informatica o processo que estava fazendo.";
                    case "Nome de usuário ou senha inválidos":
                        return "Nome de usuário ou senha inválidos!\n Favor verificar os dados informados.";
                    case "O índice estava fora do intervalo. Ele deve ser não-negativo e menor que o tamanho da coleção.\r\nNome do parâmetro: index":
                        return "O índice estava fora do intervalo. Ele deve ser não-negativo e menor que o tamanho da coleção.\r\n(Item de busca não preenchido.)";
                    case "Conversão especificada não é válida.":
                        return "Conversão especificada não é válida.";
                    case "Objeto não pode ser convertido de DBNull em outros tipos.":
                        return "Conversão especificada não é válida.";
                    case "'\u0001', valor hexadecimal 0x01, é um caractere inválido. Linha 2, posição 87.":
                        return "Arquivo XML inválido, favor substiruir ou verificar o arquivo que está importando.";
                    case "'\a', valor hexadecimal 0x07, é um caractere inválido. Linha 3, posição 741.":
                        return "Arquivo XML inválido, favor substiruir ou verificar o arquivo que está importando.";
                    default:
                        return "Erro ainda não mapeado, favor detalhar o processo para a informática. Erro: " + mensagem;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


    }
}
