# API de Gerenciamento de Recursos

Esta API foi criada como parte de um projeto acadêmico, com o objetivo de desenvolver uma aplicação estruturada seguindo boas práticas de arquitetura e padrões de design. Ela gerencia diversos recursos (como exames, usuários, etc.) e realiza operações CRUD (Create, Read, Update, Delete) utilizando um banco de dados Oracle. A documentação da API é feita com Swagger/OpenAPI, facilitando a visualização e o uso dos endpoints.

## Arquitetura

Optamos por uma arquitetura monolítica devido à sua simplicidade e praticidade, já que o projeto não exige a complexidade de uma arquitetura de microservices.

### Motivos para a escolha do modelo monolítico:

- **Facilidade de desenvolvimento**: a nossa equipe trabalhou com uma única aplicação, simplificando a configuração, execução e manutenção.
- **Menor complexidade inicial**: Microservices trariam provavelmente outras complexidades, como a comunicação entre serviços e a configuração de múltiplos bancos de dados, desnecessários para o nosso escopo do projeto.
- **Desempenho adequado**: Um sistema monolítico bem estruturado oferece desempenho suficiente sem a sobrecarga de comunicação de rede dos microservices.

Mesmo com a escolha por um monólito, priorizamos a organização do código, separando claramente em diferentes camadas da aplicação.

## Design Pattern: Singleton

Para gerenciar configurações globais da API, adotamos o padrão Singleton. Esse padrão garante que apenas uma instância da classe de configuração seja criada e reutilizada em toda a aplicação, melhorando a gestão dos recursos e facilitando o controle centralizado de variáveis globais.

### Vantagens do Singleton:

- **Controle centralizado**: A classe de configuração é inicializada uma única vez e acessível de qualquer ponto da aplicação.
- **Otimização de recursos**: Evita a criação de múltiplas instâncias desnecessárias, economizando memória.
- **Manutenção facilitada**: Centraliza todas as configurações globais em uma única classe, simplificando ajustes e manutenções.

## Práticas de Clean Code
Para manter o código legível, modular e fácil de manter, aplicamos diversas práticas de clean code durante o desenvolvimento da API:
- **Responsabilidade Única**: Cada classe e método tem uma única responsabilidade bem definida.
- **Nomes Claros e Descritivos**: Variáveis, métodos e classes utilizam nomes que refletem claramente sua função e contexto.
- **Manutenção de Código Limpo**: Funções curtas, organização lógica do código e comentários mínimos (somente onde necessário) para facilitar a leitura.
- **Injeção de Dependência**: Promove a testabilidade e modularidade da aplicação, permitindo fácil substituição de dependências, especialmente para testes.
- **Tratamento de Exceções**: Garantimos que exceções sejam tratadas adequadamente, com mensagens de erro informativas retornadas ao cliente.

## Funcionalidades de IA Generativa
Esta API conta com uma funcionalidade de previsão baseada em aprendizado de máquina (ML.NET). Utilizamos um modelo treinado para prever diagnósticos hipotéticos com base em dados de exames médicos. O modelo analisa variáveis como níveis de hormônio, colesterol e outros fatores biométricos, retornando uma previsão de diagnóstico.
### Implementação da IA Generativa:

- **Modelo de Previsão**: A IA foi integrada usando ML.NET, treinada com um conjunto de dados de exames médicos.
- **Pipeline de Treinamento**: O pipeline inclui transformação de dados e um classificador de entropia máxima para prever o diagnóstico.
- **Endpoint de Previsão**: O endpoint /api/previsao/prever recebe dados de exames e retorna uma previsão de diagnóstico.

### Exemplo de Uso

Para utilizar a IA de previsão, envie uma solicitação **POST** com os dados de exames médicos no seguinte formato JSON:

```json
{
  "NrHormonioTireostimulanteTSH": 2.8,
  "VrResultado": 245.2,
  "NrGlobulosBrancos": 6500,
  "NrHemoglobinaGlicada": 7.9,
  "NrCreatinina": 1.1,
  "NrColesterolTotal": 240,
  "NrColesterolHDL": 42,
  "NrColesterolLDL": 156
}
```

## Endpoints CRUD

A API oferece endpoints para gerenciar recursos, com operações básicas de CRUD:

- **GET**: Recupera uma lista ou um item específico.
- **POST**: Cria um novo item.
- **PUT**: Atualiza um item existente.
- **DELETE**: Remove um item.

### Exemplos de endpoints:

- `GET /api/usuarios`
- `POST /api/usuarios`
- `PUT /api/usuarios/{id}`
- `DELETE /api/usuarios/{id}`

## Documentação da API

A API é documentada com Swagger/OpenAPI, permitindo que os desenvolvedores explorem e testem os endpoints diretamente pela interface do Swagger. A documentação inclui descrições detalhadas dos endpoints e dos modelos de dados utilizados, facilitando o entendimento e a integração.

Para acessar a documentação, navegue até `https://localhost:7148/swagger/index.html`.

## Como executar a API

### Pré-requisitos:

- .NET 6.0+
- Oracle Database

### Passos para execução:

1. Clone o repositório:
   ```bash
   git clone https://github.com/Miguel-Fr3/CareMiAPI

2. Configure as variáveis de ambiente com as credenciais de acesso ao banco Oracle:

3. Execute as migrações do banco de dados:
   ```bash
   dotnet ef database update

4. Inicie a aplicação:
   ```bash
   dotnet ef database update


## Integrantes do Grupo
- rm99977 - Alberto Seiji
- rm551997 - Matheus Rodrigues
- rm99997 - Miguel Fernandes
- rm552579 - Nicolly de Almeida Gonçalves
- rm551521 - Patrick Jaguski
