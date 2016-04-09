create database SuperERP;
go
use SuperERP;
go
create table Empresa(
	ID INT identity  NOT NULL PRIMARY KEY,
	Nome VARCHAR(50) NOT NULL,
	CNPJ VARCHAR(15) NOT NULL,
	RazaoSocial VARCHAR(30) NOT NULL,
	CEP VARCHAR(8) NOT NULL,
	Endereco VARCHAR(64) NOT NULL,
	Numero VARCHAR(4) NOT NULL,
	Complemento VARCHAR(30) NOT NULL,
	Bairro VARCHAR(30) NOT NULL,
	Cidade VARCHAR(30) NOT NULL
);
go
create table Perfil(
	ID INT identity NOT NULL PRIMARY KEY,
	Nome VARCHAR(50) NOT NULL
);
go
create table Funcionalidades (
	ID INT identity NOT NULL PRIMARY KEY,
	Nome VARCHAR(50) NOT NULL,/*Vendas,Cadastro,NFe/NFSe,Compras,Financeiro,Relatorios*/
	Descricao VARCHAR(50) NOT NULL
);
go
create table Funcionalidades_Perfil (
	ID_Funcionalidades INT NOT NULL,
	ID_Perfil INT NOT NULL,
	CONSTRAINT FK_FuncionalidadesPerfil_Funcionalidades FOREIGN KEY(ID_Funcionalidades) REFERENCES Funcionalidades (ID),
	CONSTRAINT FK_FuncionalidadesPerfil_Perfil FOREIGN KEY(ID_Perfil) REFERENCES Perfil (ID)
);
go
create table Usuario(
	ID INT identity NOT NULL PRIMARY KEY,
	ID_Perfil int not null, 
	ID_Empresa int not null,
	Nome VARCHAR(200) NOT NULL,
	Email VARCHAR(150) NOT NULL,/*Será utilizado como login do usuário*/
	Senha VARCHAR(60) not null,
	CONSTRAINT FK_Usuario_Perfil FOREIGN KEY(ID_Perfil) REFERENCES Perfil (ID),
	CONSTRAINT FK_Usuario_Empresa FOREIGN KEY(ID_Empresa) REFERENCES Empresa(ID)
);
go
CREATE TABLE Dados_Bancarios(
	ID INT identity NOT NULL PRIMARY KEY,	
	ID_Empresa int not null,
	Banco VARCHAR(40) NOT NULL,
	Conta_Corrente VARCHAR(20) NOT NULL,
	Agencia VARCHAR(10) NOT NULL,
	CONSTRAINT FK_DadosBancarios_Empresa FOREIGN KEY(ID_Empresa) REFERENCES Empresa(ID)
);
go
CREATE TABLE Status_Servico(
	ID INT identity NOT NULL PRIMARY KEY,
	Nome VARCHAR(255) NOT NULL
);
go
CREATE TABLE Forma_Pgto(
	ID INT identity NOT NULL PRIMARY KEY,
	Nome VARCHAR(255) NOT NULL
);
go
CREATE TABLE Status_Venda(
	ID INT identity NOT NULL PRIMARY KEY,
	Nome VARCHAR(255) NOT NULL
);
go
CREATE TABLE PessoaFisica(
	ID INT identity NOT NULL PRIMARY KEY,
	ID_Empresa int not null,
	Nome VARCHAR(50) NOT NULL,
	CPF VARCHAR(11) NOT NULL,
	RG VARCHAR(11) NOT NULL,
	CONSTRAINT FK_PessoaFisica_Empresa FOREIGN KEY(ID_Empresa) REFERENCES Empresa(ID)
);
go
CREATE TABLE PessoaJuridica(
	ID INT identity NOT NULL PRIMARY KEY,
	ID_Empresa int not null,
	Nome VARCHAR(50) NOT NULL,
	CNPJ VARCHAR(15) NOT NULL,
	RazaoSocial VARCHAR(30) NOT NULL,
	CONSTRAINT FK_PessoaJuridica_Empresa FOREIGN KEY(ID_Empresa) REFERENCES Empresa(ID)
);
go
CREATE TABLE ClienteFornecedor(
	ID INT identity NOT NULL PRIMARY KEY,	
	ID_PJ INT,
	ID_PF INT,
	Tipo INT NOT NULL,
	CONSTRAINT FK_CliFor_PJ FOREIGN KEY(ID_PJ) REFERENCES PessoaJuridica(ID),
	CONSTRAINT FK_CliFor_PF FOREIGN KEY(ID_PF) REFERENCES PessoaFisica(ID)
);
go
CREATE TABLE DadosBancariosFornCliente(
	ID INT identity NOT NULL PRIMARY KEY,	
	Banco VARCHAR(40) NOT NULL,
	Conta_Corrente VARCHAR(20) NOT NULL,
	Agencia VARCHAR(10) NOT NULL,
	ID_ClienteFornecedor INT NOT NULL,
	CONSTRAINT FK_ProdForn_Fornecedor FOREIGN KEY(ID_ClienteFornecedor) REFERENCES ClienteFornecedor(ID)	
);
go
CREATE TABLE ClienteFornecedorContato(
	ID INT identity NOT NULL PRIMARY KEY,
	Nome VARCHAR(60) NOT NULL,
	ID_Fornecedor INT NOT NULL,
	Email VARCHAR(64) NOT NULL,
	Fone VARCHAR(15) NOT NULL,
	Cargo VARCHAR(30),
	CONSTRAINT FK_ClieFornCont_Fornecedor FOREIGN KEY(ID_Fornecedor) REFERENCES ClienteFornecedor(ID)
);
go
CREATE TABLE ClienteFornecedorEndereco(
	ID INT identity NOT NULL PRIMARY KEY,
	CEP VARCHAR(8) NOT NULL,
	ID_Fornecedor INT NOT NULL,
	Endereco VARCHAR(64) NOT NULL,
	Numero VARCHAR(4) NOT NULL,
	Complemento VARCHAR(30) NOT NULL,
	Bairro VARCHAR(30) NOT NULL,
	Cidade VARCHAR(30) NOT NULL,
	CONSTRAINT ClieFornEnd_Fornecedor FOREIGN KEY(ID_Fornecedor) REFERENCES ClienteFornecedor(ID)
);
go
CREATE TABLE Periodicidade(
	ID INT identity NOT NULL PRIMARY KEY,
	Nome VARCHAR(60) NOT NULL,
	Meses INT NOT NULL
);
go
CREATE TABLE Ncm(
	ID INT identity NOT NULL PRIMARY KEY,
	Codico VARCHAR(15) NOT NULL
);
go
CREATE TABLE Unidade_Medida(
	ID INT identity NOT NULL PRIMARY KEY,
	Nome VARCHAR(60) NOT NULL	
);
go
CREATE TABLE Categoria(
	ID INT identity NOT NULL PRIMARY KEY,
	CategoriaTipo BIT NOT NULL,
	Nome VARCHAR(60) NOT NULL
);
go
CREATE TABLE Servico (
	ID INT identity NOT NULL PRIMARY KEY,
	ID_Cliente INT NOT NULL,
	ID_Empresa int not null,
	ID_Categoria_Servico INT NOT NULL,
	Nome VARCHAR(255) NOT NULL,
	ISS FLOAT  NOT NULL,
	ICMS FLOAT  NOT NULL,
	IVA FLOAT  NOT NULL,
	ST FLOAT  NOT NULL,
	PIS FLOAT  NOT NULL,
	COFINS FLOAT  NOT NULL,
	valor FLOAT,
	custo FLOAT,
	CONSTRAINT FK_Servico_Cliente FOREIGN KEY(ID_Cliente) REFERENCES ClienteFornecedor(ID),
	CONSTRAINT FK_Servico_Categoria FOREIGN KEY(ID_Categoria_Servico) REFERENCES Categoria(ID),
	CONSTRAINT FK_Servico_Empresa FOREIGN KEY(ID_Empresa) REFERENCES Empresa(ID)
);
go
CREATE TABLE Produto(
	ID INT identity NOT NULL PRIMARY KEY,
	ID_Empresa int not null,
	ID_Categoria INT NOT NULL,
	ID_Cliente INT NOT NULL,
	ID_Ncm INT,
	ID_Unidade_Medida INT,
	ICMS FLOAT  NOT NULL,
	IPI FLOAT  NOT NULL,
	IVA FLOAT  NOT NULL,
	ST FLOAT  NOT NULL,
	PIS FLOAT  NOT NULL,
	COFINS FLOAT  NOT NULL,
	Nome VARCHAR(255) NOT NULL,
	Codigo_Cliente INT NOT NULL,
	Codigo_Barras INT NOT NULL,
	Valor_Venda FLOAT NOT NULL,
	Estoque INT NOT NULL,
	EstoqueMax INT NOT NULL,
	EstoqueMin INT NOT NULL,
	Peso_Liquido FLOAT,
	Peso_Bruto FLOAT,
	ean VARCHAR(20),
	CONSTRAINT FK_Prod_Fornecedor FOREIGN KEY(ID_Cliente) REFERENCES ClienteFornecedor(ID),
	CONSTRAINT FK_Prod_Cat FOREIGN KEY(ID_Categoria) REFERENCES Categoria(ID),
	CONSTRAINT FK_Prod_UnidMed FOREIGN KEY(ID_Unidade_Medida) REFERENCES Unidade_Medida(ID),
	CONSTRAINT FK_Prod_Ncm FOREIGN KEY(ID_Ncm) REFERENCES Ncm(ID),
	CONSTRAINT FK_Prod_Empresa FOREIGN KEY(ID_Empresa) REFERENCES Empresa(ID)
);
go
CREATE TABLE ProdutoFornecedor(
	ID INT identity NOT NULL PRIMARY KEY,
	ID_Produto INT NOT NULL,
	ID_Fornecedor INT NOT NULL,
	Valor_Custo FLOAT NOT NULL,
	CONSTRAINT FK_ProdutoForn_Fornecedor FOREIGN KEY(ID_Fornecedor) REFERENCES ClienteFornecedor(ID),
	CONSTRAINT FK_ProdutoForn_Produto FOREIGN KEY(ID_Produto) REFERENCES Produto(ID)
);
go
CREATE TABLE Ordem_Servico(
	ID INT identity NOT NULL PRIMARY KEY,
	ID_Empresa int not null,
	Nome VARCHAR(255) NOT NULL,	
	ID_Cliente INT NOT NULL,
	ID_Servico INT NOT NULL,
	ID_Status INT NOT NULL,
	Numero_Os VARCHAR(12) NOT NULL,
	DataI_Inicio DATE NOT NULL,
	DataI_Entrega DATE NOT NULL,
	Equipamento_Recebido VARCHAR(255),
	NumeroSerie VARCHAR(15),
	Marca VARCHAR(255),
	Modelo VARCHAR(255),
	Obs_Recebimento VARCHAR(500),
	Obs_Problema VARCHAR(500),
	Descr_Servico VARCHAR(500),
	Obs_Interno VARCHAR(500),
	CONSTRAINT FK_OrdermServico_Status FOREIGN KEY(ID_Status) REFERENCES Status_Servico(ID),	
	CONSTRAINT FK_OrdemSerivco_Cliente FOREIGN KEY(ID_Cliente) REFERENCES ClienteFornecedor(ID),
	CONSTRAINT FK_OrdemSerivco_Servico FOREIGN KEY(ID_Servico) REFERENCES Servico(ID),
	CONSTRAINT FK_OrdemSerivco_Empresa FOREIGN KEY(ID_Empresa) REFERENCES Empresa(ID)
);
go
CREATE TABLE Compra(
	ID INT identity NOT NULL PRIMARY KEY,
	ID_Empresa int not null,
	ID_Fornecedor INt NOT NULL,
	ID_Status INT NOT NULL,
	Compra_Num INT NOT NULL,
	Data_Compra DATE NOT NULL,
	Desconto DECIMAL(9,2) NOT NULL,
	ID_FormaPgto INT NOT NULL,
	Observacoes VARCHAR(300) NOT NULL,
	ID_conta INT NOT NULL,
	CONSTRAINT FK_Compra_CC FOREIGN KEY(ID_conta) REFERENCES Dados_Bancarios(ID),
	CONSTRAINT FK_Compra_Cliente FOREIGN KEY(ID_Fornecedor) REFERENCES ClienteFornecedor(ID),
	CONSTRAINT FK_Compra_Status FOREIGN KEY(ID_Status) REFERENCES Status_Venda(ID),
	/*CONSTRAINT FK_Compra_Vendedor FOREIGN KEY(ID_Vendedor) REFERENCES Vendedor(ID),*/
	CONSTRAINT FK_Compra_FormaPgto FOREIGN KEY(ID_FormaPgto) REFERENCES Forma_Pgto(ID),
	CONSTRAINT FK_Compra_Empresa FOREIGN KEY(ID_Empresa) REFERENCES Empresa(ID)
);
go
CREATE TABLE Compra_Ativos(
	ID INT identity NOT NULL PRIMARY KEY,
	ID_Compra INT NOT NULL,
	ID_Produto INT,
	ID_Servico INT,
	Imposto DECIMAL (4,2),
	Detalhes VARCHAR(300),
	Quantidade INT,
	CONSTRAINT FK_CompraAtivo_Venda FOREIGN KEY(ID_Compra) REFERENCES Compra(ID),
	CONSTRAINT FK_CompraAtivo_Produto FOREIGN KEY(ID_Produto) REFERENCES Produto(ID),
	CONSTRAINT FK_CompraAtivo_Servico FOREIGN KEY(ID_Servico) REFERENCES Servico(ID),
);
go
CREATE TABLE Venda(
	ID INT identity NOT NULL PRIMARY KEY,
	ID_Empresa int not null,
	ID_Usuario int not null,
	ID_Cliente INT NOT NULL,
	ID_Orcamento INT,
	ID_Status INT NOT NULL,
	ID_conta INT NOT NULL,
	ID_FormaPgto INT NOT NULL,
	Venda_Num INT NOT NULL,
	Data_Venda DATE NOT NULL,
	Contrato BIT NOT NULL,
	Desconto FLOAT NOT NULL,
	Observacoes VARCHAR(300) NOT NULL,
	CONSTRAINT FK_Venda_Cliente FOREIGN KEY(ID_Cliente) REFERENCES ClienteFornecedor(ID),
	CONSTRAINT FK_Venda_Status FOREIGN KEY(ID_Status) REFERENCES Status_Venda(ID),
	CONSTRAINT FK_Venda_CC FOREIGN KEY(ID_conta) REFERENCES Dados_Bancarios(ID),
	CONSTRAINT FK_Venda_Orcamento FOREIGN KEY(ID_Orcamento) REFERENCES Venda(ID),
	CONSTRAINT FK_Venda_FormaPgto FOREIGN KEY(ID_FormaPgto) REFERENCES Forma_Pgto(ID),
	CONSTRAINT FK_Venda_Empresa FOREIGN KEY(ID_Empresa) REFERENCES Empresa(ID),
	CONSTRAINT FK_Venda_Usuario FOREIGN KEY(ID_Usuario) REFERENCES Usuario(ID)
);
go
CREATE TABLE Venda_Ativos(
	ID INT identity NOT NULL PRIMARY KEY,
	ID_Venda INT NOT NULL,
	ID_Produto INT,
	ID_Servico INT,
	ID_Compra INT,
	Imposto FLOAT ,
	Detalhes VARCHAR(300),
	Quantidade INT,
	CONSTRAINT FK_Compra FOREIGN KEY(ID_Compra) REFERENCES Compra(ID),
	CONSTRAINT FK_VendaAtivo_Venda FOREIGN KEY(ID_Venda) REFERENCES Venda(ID),
	CONSTRAINT FK_VendaAtivo_Produto FOREIGN KEY(ID_Produto) REFERENCES Produto(ID),
	CONSTRAINT FK_VendaAtivo_Servico FOREIGN KEY(ID_Servico) REFERENCES Servico(ID),
);
go
CREATE TABLE Contrato_Venda(
	ID INT identity NOT NULL PRIMARY KEY,
	ID_Periodicidade INT NOT NULL,
	ID_Venda INT NOT NULL,
	Dia_Cobranca INT NOT NULL,
	Data_Inicio DATE NOT NULL,
	Data_Fim DATE NOT NULL,
	Juros DECIMAL(4,2) NOT NULL,
	Ocorrencias INT NOT NULL,
	CONSTRAINT FK_ContratoVenda_Periodicidade FOREIGN KEY(ID_Periodicidade) REFERENCES Periodicidade(ID),
	CONSTRAINT FK_ContratoVenda_Venda FOREIGN KEY(ID_Venda) REFERENCES Venda(ID),
);
go
CREATE TABLE Parcelamento(
	ID INT identity NOT NULL PRIMARY KEY,
	ID_Compra INT not null,
	ID_Venda INT not null,
	Numero_Parcela int not null,
	Valor  DECIMAL (4,2) not null,
	Pago bit,
	Data_Pagamento Date not null,
	Data_Pago Date not null,
	CONSTRAINT FK_Parcelamento_Compra FOREIGN KEY(ID_Compra) REFERENCES Compra(ID),
	CONSTRAINT FK_Parcelamento_Venda FOREIGN KEY(ID_Venda) REFERENCES Venda(ID)
)