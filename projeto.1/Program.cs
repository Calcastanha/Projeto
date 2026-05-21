// See https://aka.ms/new-console-template for more information

// string[] nomes =
// {
    // "Miqueias",
    // "Abel",
    // "Dadja"
// };
// string[] noms = new string[3];
// Console.WriteLine(nomes[2]);


//


// string[] meses =
// {
    // "Janeiro",
    // "Fevereiro",
    // "Março"
// };
// int contador = 0;
// while(contador <= meses.Length)
// {
    // Console.WriteLine(meses[contador]);
    // contador++;
//};


// 


string[] usuarios = new string[50];
bool sair = false;
int contador = 0;

while (!sair)
{
  Console.WriteLine("1 - Cadastrar usuario");
  Console.WriteLine("2 - listar usuario");  
  Console.WriteLine("3 - Excluir usuario");
  Console.WriteLine("4 - sair");    
  int opcaoSelecionada = int.Parse(Console.ReadLine());
   switch (opcaoSelecionada)
    {
        case 1:
            Console.WriteLine("Digite o nome do usuario");
            string nomeUsuario = Console.ReadLine();

            usuarios[contador] = nomeUsuario;
            contador++;
            break;

        case 2:
            Console.WriteLine("Segue abaixo sua lista de usuarios");
            int contadorInterno = 0;

            while(contadorInterno < usuarios.Length)
            {
                if(usuarios[contadorInterno] != null)
                {
                 Console.WriteLine(usuarios[contadorInterno]);   
                }
                contadorInterno = contadorInterno + 1;
            }
            break;

        case 3:
            Console.WriteLine("Qual usuario você quer excluir");
            int excluir = int.Parse(Console.ReadLine());

            usuarios[excluir] = null;
            Console.WriteLine("Usuario excluido");
            break;
        default:
           sair = true;
           Console.WriteLine("Adeus");
           break;
    }
}