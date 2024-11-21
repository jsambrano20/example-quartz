# ExampleQuartz - Agendamento de Jobs com Quartz.NET

Este projeto demonstra como usar o Quartz.NET para agendar e executar jobs em uma aplicação .NET.

## Descrição

O **Quartz.NET** é um agendador de tarefas poderoso que permite que você agende jobs para serem executados em intervalos específicos. Neste exemplo, criamos um agendador que executa um job simples a cada 10 segundos.

## Funcionalidade

- **Scheduler**: Gerencia a execução de jobs, incluindo sua configuração e agendamento.
- **Job**: Realiza a tarefa que será executada. No exemplo, o job imprime "Executando o job!" no console.
- **Trigger**: Define quando e com que frequência o job será executado (a cada 10 segundos).

## Tecnologias

- .NET 6 ou superior
- Quartz.NET
- C#

## Como Rodar

### 1. Clonar o repositório

Clone este repositório em sua máquina local utilizando o seguinte comando:

```bash
git clone https://github.com/jsambrano20/example-quartz
