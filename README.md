# SalesSystem-API
Sales and Inventory Management System


## Projeto: Sistema de Gerenciamento de Vendas e Estoque


# 1. Requisitos Básicos (API)
Neste estágio, o objetivo é estabelecer a estrutura básica da API com operações CRUD simples para produtos e vendas, utilizando SQL para persistência de dados e Mediator para separar a lógica de negócios.

Rotas da API e Funcionalidades:
Criar Produto

Endpoint: POST /api/products
Corpo da Requisição:
json:
{
  "name": "Nome do Produto",
  "price": 19.99,
  "quantity": 100
}

SQL: Utilizar uma consulta INSERT INTO para adicionar o produto na tabela Products.
Mediator: Criar um CreateProductCommand para encapsular os dados da requisição e um CreateProductHandler para processar o comando. O handler deve salvar o produto no banco.
Comentário sobre a implementação:

Mediator: Ao usar o Mediator, você pode separar a lógica de criação do produto (validar dados, inserir no banco, etc.) do controller. Isso facilita a manutenção e a escalabilidade da aplicação.
SQL: A inserção de novos produtos é simples, mas o uso de stored procedures ou transações pode ser considerado para garantir a integridade dos dados.
Listar Todos os Produtos

Endpoint: GET /api/products
SQL: Fazer uma consulta SELECT * FROM Products para retornar todos os produtos da tabela Products.
Mediator: Criar um GetAllProductsQuery para buscar todos os produtos e um GetAllProductsHandler para processar e retornar os dados da consulta.
Comentário sobre a implementação:

Mediator: O uso do Mediator para consultas como essa é muito útil, pois você centraliza a lógica de consulta e facilita a aplicação de filtros, paginação e outras operações sem sobrecarregar os controllers.
SQL: A consulta simples de SELECT pode ser estendida para incluir filtros e ordenação, dependendo das necessidades do projeto.
Obter um Produto por ID

Endpoint: GET /api/products/{id}
SQL: Consultar o produto pelo ID com SELECT * FROM Products WHERE ProductId = @Id.
Mediator: Criar um GetProductByIdQuery e um GetProductByIdHandler para buscar o produto específico e retornar o resultado.
Comentário sobre a implementação:

SQL: A consulta deve garantir que o produto existe. Usar WHERE para filtrar pelo ID e garantir que o resultado seja único.
Mediator: Facilita a implementação de lógicas como validação de entrada ou formatação dos dados antes de enviar a resposta para o cliente.

-----------------

# 2. Requisitos Intermediários (API)
Aqui, a API começa a ter funcionalidades mais complexas, como o controle de vendas, a integração com o estoque e o uso de consultas SQL mais avançadas.

Rotas da API e Funcionalidades:
Criar Venda

Endpoint: POST /api/sales
Corpo da Requisição:
json:
{
  "customerId": 1,
  "products": [
    { "productId": 2, "quantity": 3 },
    { "productId": 5, "quantity": 1 }
  ]
}
SQL:
Inserir a venda na tabela Sales com INSERT INTO Sales (CustomerId, SaleDate) VALUES (@CustomerId, @SaleDate).
Atualizar o estoque com UPDATE Products SET Quantity = Quantity - @Quantity WHERE ProductId = @ProductId.
Mediator: Criar um CreateSaleCommand para encapsular os dados da venda e um CreateSaleHandler para processar o comando, criar a venda e atualizar o estoque de produtos.
Comentário sobre a implementação:

Mediator: Usando o Mediator, você pode orquestrar o processo da venda (criar a venda, diminuir o estoque, registrar a transação) sem que o controller tenha que lidar com toda a lógica de negócios.
SQL: As transações podem ser usadas aqui para garantir que todas as operações sejam feitas de maneira atômica. Se falhar em qualquer parte, a transação pode ser revertida.
Listar Vendas

Endpoint: GET /api/sales
SQL: Realizar uma consulta SELECT * FROM Sales para listar todas as vendas, podendo incluir um INNER JOIN com a tabela SalesDetails para exibir os produtos vendidos.
Mediator: Criar um GetSalesQuery e um GetSalesHandler para buscar todas as vendas, com a possibilidade de aplicar filtros como data ou status da venda.
Comentário sobre a implementação:

SQL: Um INNER JOIN entre as tabelas Sales e SalesDetails seria útil para listar todos os produtos vendidos em cada transação. Você pode também incluir filtros, como data de venda ou o status da transação.
Mediator: Aqui, o Mediator ajuda a centralizar as regras de consulta, como filtros ou paginação, fora do controller, tornando o código mais modular.
Obter Detalhes de uma Venda

Endpoint: GET /api/sales/{id}
SQL: Consultar os detalhes da venda com SELECT * FROM Sales WHERE SaleId = @Id e combinar com INNER JOIN SalesDetails para listar os produtos.
Mediator: Criar um GetSaleByIdQuery e um GetSaleByIdHandler para obter os detalhes de uma venda específica.
Comentário sobre a implementação:

SQL: Uma consulta detalhada que envolve múltiplas tabelas, como Sales e SalesDetails, com INNER JOIN pode ser usada para mostrar todos os produtos vendidos em uma transação específica.
Mediator: Utilizar o Mediator para centralizar a lógica de consulta torna o código mais limpo e reutilizável, além de facilitar a introdução de novos filtros ou regras de negócios.

--------

# 3. Requisitos Avançados (API)
Agora, a API deve ter funcionalidades mais complexas, como controle de erros, lógica de negócios avançada e otimizações nas consultas.

Rotas da API e Funcionalidades:
Atualizar Produto (estoque)

Endpoint: PUT /api/products/{id}
Corpo da Requisição:
json
Copiar
{
  "name": "Updated Product Name",
  "price": 29.99,
  "quantity": 120
}
SQL: UPDATE Products SET Name = @Name, Price = @Price, Quantity = @Quantity WHERE ProductId = @ProductId.
Mediator: Criar um UpdateProductCommand para encapsular os dados da atualização e um UpdateProductHandler para processar o comando.
Comentário sobre a implementação:

SQL: Ao atualizar dados, é importante garantir que o produto realmente exista e que os valores são válidos antes de realizar o UPDATE.
Mediator: O uso do Mediator para tratar atualizações evita a repetição de código e torna o processo de validação e atualização mais organizado.
Relatórios de Vendas

Endpoint: GET /api/reports/sales
SQL: Criar uma consulta complexa com JOIN e GROUP BY para calcular o total de vendas por produto ou cliente, ou gerar relatórios diários/anuais.
Mediator: Criar um GenerateSalesReportQuery e um GenerateSalesReportHandler para gerar relatórios detalhados.
Comentário sobre a implementação:

SQL: Consultas avançadas como GROUP BY, SUM, ou COUNT são essenciais para relatórios de vendas. O uso de JOIN entre as tabelas Sales, SalesDetails e Products é fundamental para gerar um relatório completo.
Mediator: A centralização da lógica de geração de relatórios via Mediator permite que você modifique facilmente os tipos de relatórios ou adicione novos parâmetros de filtro.



-------------------

Implementação do Front será feita após a conclusão so Back-End
