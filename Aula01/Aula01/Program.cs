// See https://aka.ms/new-console-template for more information



//string teste = "Texto";
//int numero = 1;
//char caracter = 'a';
//decimal numeroReal = 1.03123213123111M;
//double moeda = 1.5444444444444444444444444444444444444444444444444;
//bool validacao = true;
//long longo = 1001010;
//string[] stringArray =  new string[] { "A", "B" };
//int[] intArray = new int[] { 1 ,2 ,3  };

////rariadade
//uint teste2 = 1;

//var variavel = "1";

//string texto2 = "texto2";

//foreach (var item in texto2)
//{
//    Console.WriteLine(item);
//}

#region String
//string texto2 = "Teste";

//var texto3 = texto2 + "AAA";
//Console.WriteLine(texto3);

//Console.WriteLine(texto2);
//texto2 += "BBB";
//Console.WriteLine(texto2);

////Convertendo texto para maisculo
//string textoUpper = texto2.ToUpper();
//Console.WriteLine(textoUpper);

////Convertendo texto para minusculo
//textoUpper = texto2.ToLower();
//Console.WriteLine(textoUpper);

////Mostrando que não houve alteração no valor
//Console.WriteLine(texto2);



#endregion

#region int

//int numero1 = 2;

//int testeNumero = numero1 + 1;
//int testeNumero1 = numero1 - 1;
//int testeNumero3 = numero1 * 3;

//numero1 += 1;
//Console.WriteLine(numero1);

#endregion

#region Array

//string[] stringArray =  new string[] { "A", "B" };
//Console.WriteLine(stringArray.Length);

#endregion

#region bool

//bool verdadeiro = !false;
//Console.WriteLine(verdadeiro);

//bool falso = !true;
//Console.WriteLine(falso);

#endregion

#region conversões

//string teste = "1a";

//int numero = Convert.ToInt32(teste);

//bool conversaoDeuCerto = int.TryParse(teste, out int numero);

//Console.WriteLine(conversaoDeuCerto);
//Console.WriteLine(numero);

//int numeroConvert = 1;
//string testeString = Convert.ToString(true);
//Console.WriteLine(testeString.GetType());

//string numero = "texto" + 1;
//Console.WriteLine(numero);

//int? numero = null;
//string texto = numero.ToString();
//Console.WriteLine(texto);

#endregion

#region estruturas condicionais

//string nomeUsuario = null;

//if (nomeUsuario == null)
//{
//    Console.WriteLine("");
//}
//if (nomeUsuario.Contains("A"))
//{
//    Console.WriteLine(nomeUsuario.ToUpper());
//}
//else
//{
//    Console.WriteLine(nomeUsuario.ToUpper());
//}

//Console.WriteLine(nomeUsuario?.ToUpper() ?? "Não tem nome");
//Console.WriteLine(nomeUsuario == null ? "Não tem nome" : nomeUsuario?.ToUpper());

//string teste = null;
//teste ??= "testedaslkjdlkasjdlaksjd";
//Console.WriteLine(teste);

//string edi = "MSC1";

//if (edi == "HLC")
//    Console.WriteLine(edi);
//if(edi == "MAE")
//    Console.WriteLine(edi);
//if(edi == "MSC")
//    Console.WriteLine(edi);
//else
//    Console.WriteLine("Nada");

//switch (edi)
//{
//    case "HLC":
//        Console.WriteLine("Passei aqui HLC");
//        break;
//    case "MAE":
//        Console.WriteLine("Passei aqui MAE");
//        break;
//    case "MSC":
//        Console.WriteLine("Passei aqui MSC");
//        break;
//    default:
//        Console.WriteLine("Default");
//        break;
//}

#endregion

