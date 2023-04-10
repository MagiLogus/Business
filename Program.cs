// Uma certa empresa fez uma
//pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
//produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
//A.    
//O número de pessoas que responderam SIM.

//B.    
//O número de pessoas que responderam NÃO;

//C.   
//O número de mulheres que responderam SIM;

//D.   
//A porcentagem de homens que responderam NÃO entre todos os homens analisados.

//Entrada

char sexo;
char resposta;
int totalSim = 0;
int totalNao = 0;
int totalMulheresSim = 0;
int totalHomensNao = 0;
int totalNumHomens = 0;
int totalNumMulheres = 0;
double pctHomensNao = 0.0;

//Processamento
for (int i = 1; i <= 3; i++) 
{
Console.WriteLine($"Entrevistado {i}:");
Console.WriteLine("Sexo: 'M' para masculino ou 'F' para feminino: ");
sexo = char.Parse(Console.ReadLine().ToLower());
Console.WriteLine("Resposta 'S' para sim ou 'N' para não: ");
resposta = char.Parse(Console.ReadLine().ToLower());

if (resposta == 's') 
{
totalSim++; 
if (sexo == 'f') 
{
totalMulheresSim++; 
}
} 
else if (resposta == 'n') 
{
totalNao++; 
if (sexo == 'm') 
{
totalHomensNao++; 
totalNumHomens++; 
}
}

if (sexo == 'm') 
{
totalNumHomens++; 
} 
else if (sexo == 'f') 
{
totalNumMulheres++;
}
}

if (totalNumHomens > 0) 
{
pctHomensNao = ((double)totalHomensNao / totalNumHomens) * 100.0; 
}

//Saida
Console.WriteLine($"O número de pessoas que responderam SIM foi de: {totalSim}");
Console.WriteLine($"O número de pessoas que responderam NÃO foi de: {totalNao}");
Console.WriteLine($"O número de mulheres que responderam SIM foi de: {totalMulheresSim}");
Console.WriteLine($"A porcentagem de homens que responderam NÃO foi de: {pctHomensNao:F2}%");




  

        

        
    




