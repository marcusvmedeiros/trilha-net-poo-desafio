# Resolução do desafio DIO - POO

## Contexto do desafio
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

# Alterações e soluções:
## Solução da classes Iphone e Nokia:
Para a solução da classe Iphone, foi feito o seguinte:
- Adicionar o ": Smartphone" para realizar a herança da classe Smartphone
- Implementar o método construtor herdando da classeSmartphone utilizando o "base()"
- Sobrescrever o método "InstalarAplicativo"

```
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string NomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{NomeApp}\" no Iphone");
        }
    }

```

```
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string NomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{NomeApp}\" no Nokia");
        }
    }
```

## Fazendo o teste na classe "Program.cs":

```
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456", "tipo 1", "11111111", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("999999", "15 Pro Max", "22222222", 512);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
```
