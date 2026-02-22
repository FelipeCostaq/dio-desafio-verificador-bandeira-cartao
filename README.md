# Verificador de Bandeira de Cartão (C#)

Um utilitário simples em C# para identificar a bandeira de cartões de crédito via Console, baseado nos primeiros dígitos (IIN/BIN).

## Funcionalidades
* **Identificação de Bandeira:** Detecta Visa, Mastercard, Amex, Elo, Discover e Hipercard.
* **Tratamento de Input:** Remove espaços automaticamente e valida se a entrada é numérica.
* **Interface Simples:** Utiliza cores no console para facilitar a leitura de erros.

## Como Executar
1. Certifique-se de ter o [.NET 10 SDK](https://dotnet.microsoft.com/download) e Git instalado.
2. Clone o projeto:
   ```bash
   git clone https://github.com/FelipeCostaq/dio-desafio-verificador-bandeira-cartao
   ```
3. Acesse a pasta:
   ```bash
   cd dio-desafio-verificador-bandeira-cartao
   ```
4. Inicie a aplicação:
  ```bash
  dotnet run
  ```

## Regras de Identificação

#### O projeto utiliza os prefixos padrões da indústria:

- Visa: Começa com 4.

- Mastercard: Faixas 51-55 ou 2221-2720.

- Amex: Começa com 34 ou 37.

- Elo: Prefixos como 4011, 4389, 6363, entre outros.

- Discover: Prefixos 6011, 644 ou 65.
