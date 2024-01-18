﻿using ExemploExplorando.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Numerics;

int numero = 20;
bool par = false;

//IF ternário
par = numero .EhPar();

int teste = 0;
teste.EhPar();

string mensagem = "O número " + numero + " " + "é " + (par ? "par": "ímpar");
Console.WriteLine(mensagem);




// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElementoArray(30);

// Console.WriteLine(arrayInteiro[0]);


// MeuArray<string> arrayString = new MeuArray<string>();

// arrayString.AdicionarElementoArray("hhh");

// Console.WriteLine(arrayString[0]);




// dynamic variavelDinamica = 4;


// Console.WriteLine($"O tipo da varíavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");





// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<VendaDeserializacao> listaVenda =JsonConvert.DeserializeObject<List<VendaDeserializacao>>(conteudoArquivo);

// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach(var venda in listaAnonimo) {

//     Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }


// var tipoAnonimo = new { Nome = "Denis", Sobrenome = "Sorrilha", Altura = 1.80};


// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);


// bool? desejaReceberEmail = null;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value) {
//     Console.WriteLine("O usuário optou por receber e-mail.");
// } else {
//     Console.WriteLine("O usuário não respondeu ou não optou por receber e-mail");
// }

// // DESERIALIZAÇÃO:

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<VendaDeserializacao> listaVendas = JsonConvert.DeserializeObject<List<VendaDeserializacao>>(conteudoArquivo);

// foreach (VendaDeserializacao venda in listaVendas) {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" +
//     $" {(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");
// }




// SERIALIZAÇÃO:

// DateTime dataAtual = DateTime.Now;


// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de Escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 1500.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializando = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializando);

// Console.WriteLine(serializando);




// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("RJ", "Rio de Janeiro");
// estados.Add("MG", "Minas Gerais");
// estados.Add("ES", "Espírito Santo");

// Console.WriteLine(estados["SP"]);

// // foreach(var item in estados ) {
// //     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// // }

// // estados.Remove("ES");
// // estados["SP"] = "São Paulo = valor alterado.";

// // foreach(var item in estados ) {
// //     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// // }

// string chave = "RJ";
// Console.WriteLine($"Verificando o elemento {chave}");

// if (estados.ContainsKey(chave)) {
//     Console.WriteLine($"Valor existente {chave}");
// } else {
//     Console.WriteLine($"Valor inexistente. Pode ser adicionado ao dicionário. {chave}");
// }



// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha) {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(22);

// foreach(int item in pilha) {
//     Console.WriteLine(item);
// }

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(6);
// fila.Enqueue(12);
// fila.Enqueue(24);

// foreach(int item in fila) { 
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach(int item in fila) { 
//     Console.WriteLine(item);
//     Console.WriteLine(a);
//     Console.WriteLine
// }


// new ExemploExcecao().Metodo1();


// try {
    
//     string[] linhas =  File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

//     foreach(string linha in linhas) {
//         Console.WriteLine(linha);
//     }

// } catch(FileNotFoundException ex) {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");

// } catch(DirectoryNotFoundException ex) {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Diretório não encontrado. {ex.Message}");

// } catch(Exception ex) {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// } finally {
//     Console.WriteLine("Chegou até aqui!");
// }

//DateTime data = DateTime.Now;

//Console.WriteLine(data.ToShortTimeString());
//Console.WriteLine(data.ToShortDateString());

// string dataString = "2023-12-28 21:30";

// DateTime data = DateTime.Parse(dataString);

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucesso) {
//     Console.WriteLine("Conversão com sucesso! Data: {data}");
// } else {
//     Console.WriteLine($"{dataString} não é uma data válida!");
// }

// //DateTime data = DateTime.Parse(dataString);
// Console.WriteLine(data);



// CultureInfo.DefaultThreadCurrentCulture= new CultureInfo("pt-BR");

// decimal valorMonetario = 1942.40M;

// Console.WriteLine(valorMonetario.ToString("N5"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));


// int? numero1 = 10;
// int? numero2 = 20;

// int? resultado = numero1 + numero2;

// Console.WriteLine(resultado);


// Pessoa p1 = new Pessoa(nome: "Denis", sobrenome: "Sorrilha");
// Pessoa p2 = new Pessoa(nome: "Douglas", sobrenome: "Pereira");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();



// Pessoa p1 = new Pessoa();

// p1.Nome = "Denis";
// p1.Sobrenome = "Sorrilha";
// p1.Idade = 42;
// p1.Apresentar();
