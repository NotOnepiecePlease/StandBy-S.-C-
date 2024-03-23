



![enter image description here](https://img.shields.io/badge/Maintained-yes-green.svg)
![enter image description here](https://aleen42.github.io/badges/src/photoshop.svg)
![enter image description here](https://img.shields.io/badge/Microsoft_SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
![enter image description here](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![enter image description here](https://img.shields.io/badge/Express-Express?style=for-the-badge&logoColor=black&label=Dev&labelColor=orange&color=black)

<h2>StandBy System - C#</h2>

**O REPOSITÓRIO PRINCIPAL FOI MOVIDO PARA UM REPOSITÓRIO PRIVADO, MAS MANTEREI ESTE README SEMPRE ATUALIZADO** 

##
### Sistema de Gerenciamento Integrado para Assistência de Dispositivos Móveis

O sistema oferece um abrangente conjunto de ferramentas para gerenciar faturamento, clientes, dispositivos e serviços específicos para assistências de dispositivos móveis, englobando celulares, tablets, notebooks e outros dispositivos similares.

Desenvolvido sob medida para atender às necessidades específicas dos clientes, o sistema é altamente customizado para proporcionar uma experiência totalmente adaptada. No entanto, é importante observar que caso seja utilizado para outros propósitos ou por diferentes assistências técnicas, podem ser necessários ajustes ou até mesmo modificações substanciais.

Inicialmente criado como um projeto sem fins lucrativos, impulsionado pela busca de experiência e pelo aprimoramento de habilidades, o sistema evoluiu para se tornar uma das soluções mais abrangentes disponíveis para assistências técnicas em geral.

Estamos comprometidos em fornecer uma plataforma robusta e intuitiva, projetada para otimizar os processos de gerenciamento e proporcionar uma experiência excepcional tanto para os clientes quanto para suas respectivas bases de usuários.


## Funcionalidades por Módulo  
### Módulo de Clientes
#### Funcionalidades:

- Cadastrar Clientes (***Nome, CPF/CNPJ, Nascimento, Sexo, Numero Contato, Numero Recado, Parentesco, Nome Recado, CEP, Rua, Complemento, Bairro, Cidade, Estado***)
 - Buscar endereço por CEP (via API)
 - Editar Cliente
 - Remover Cliente
 - Listar Clientes
 - Buscar cliente por Nome
 - **Clientes nao podem ser removidos se existirem serviços vinculados**
---

### Módulo de Serviços
#### Funcionalidades:

- Cadastrar Serviço (***São muitas informações, veja as imagens no final do readme para ter uma noção melhor***)
- Editar Serviço
- Remover Serviço
- Listar Serviços
- Buscar Serviços
- Sistema de Atraso. 
		- ATÉ 3 HORAS = **LARANJA**
		- 48 HORAS = **VERDE**
		- 5 DIAS = **VERMELHO**
		- 15 DIAS = **CINZA**
- Sistema de filtragem avançado
- Impressão de nota não fiscal
- Ordem de Serviço de Entrada (folha A4)
- Ordem de Serviço de Saída (folha A4)
- Checklist do aparelho na entrada e saída
- Editar checklists
- Compras de peças para serviço
- Uso de peças em estoque para o serviço
 - Tela de serviços concluidos
 - Garantia
---
### Módulo de Lucros/Gastos
#### Funcionalidades:
 - Busca dos lucros entre datas determinadas 
 - Cadastro de gastos com a empresa 
 - Busca de dados por nome
 - Busca de dados entre datas
 - Cadastro de gastos temporários 
 - Calculo dos lucros do mes atual automaticamente
---

### Módulo de Graficos
#### Funcionalidades:
 - Dados dos lucros semanais
 - Dados dos lucros mensais 
 - Dados dos lucros anuais 
---

### Modulo de Anotações
#### Funcionalidades:
 - Inserir anotações
 - Abrir anotações salvas 
 - Salvar anotações 
 - Customização do bloco de notas para atender o cliente. 
---

### Modulo de AutoUpdate
#### Funcionalidades:
 - Verificação de Versão na nuvem.
 - Validação por Hash Code
 - Automaticamente baixa e instala o sistema.
---

### Modulo de Estoque
#### Funcionalidades:
 - Cadastrar produtos no estoque
 - Editar produtos
 - Remover produtos
 - Lista produtos
 - Edição inline para facilitar o fluxo de trabalho
 - Uso do leitor de codigo de barras
 - Codigo automatico
---

### Modulo de PDV
#### Funcionalidades:
 - Leitura de produto por leitor de codigo de barras
 - Total de venda
 - Formas de pagamento customizaveis
 - Soma de produto em caso de codigo repetido
 - Edição inline para facilitar o fluxo de trabalho
 - Acessibilidade (***uso do teclado apenas***)
 - Zerar venda
 - Finalizar venda
 - Salvar uma pré-venda (***para produtos fixos***)
 - Gerar nota nao fiscal
 - Venda vinculada a um cliente (***ou sem vinculos caso nao exista cadastro***)

---
### Algumas imagens não foram atualizadas pois não houveram mudanças significativas no layout ou na funcionalidade
# **TELA PRINCIPAL**![alt text](https://i.imgur.com/kFgDsdD.png)
&nbsp;
&nbsp;
# SERVIÇOS EM ANDAMENTO![alt text](https://i.imgur.com/TU5HITf.png)
&nbsp;
&nbsp;
# EDIÇÃO DE SERVIÇOS ![alt text](https://i.imgur.com/m2wRgly.png)
&nbsp;
&nbsp;
# TELA DE COMPRAS![alt text](https://i.imgur.com/wpPBQlx.png)
&nbsp;
&nbsp;
# TELA DE PAGAMENTO
![](https://i.imgur.com/yYsmh2o.png)
&nbsp;
&nbsp;
# O.S - ENTRADA ![alt text](https://i.imgur.com/xZil4ql.png)
&nbsp;
&nbsp;
# IMPRESSÃO O.S - ENTRADA![alt text](https://i.imgur.com/N5YNqEt.png)
&nbsp;
&nbsp;
# O.S - SAIDA![alt text](https://i.imgur.com/w6Om1sq.png)
&nbsp;
&nbsp;
# IMPRESSÃO O.S - SAIDA![alt text](https://i.imgur.com/n0EE5Ir.png)
&nbsp;
&nbsp;
# CONFIG - ITEMS DAS COMBOBOX's![alt text](https://i.imgur.com/M5jQYf8.png)
&nbsp;
&nbsp;
# CADASTRO DE CLIENTE![alt text](https://i.imgur.com/JCI2zAr.png)
&nbsp;
&nbsp;
# EDIÇÃO DE CLIENTES![alt text](https://i.imgur.com/vdlxslm.png)
&nbsp;
&nbsp;
# SERVIÇOS CONCLUÍDOS![alt text](https://i.imgur.com/UX8YHiO.png)
&nbsp;
&nbsp;
# GRÁFICO SERVIÇOS POR MÊS ![](https://i.imgur.com/X6qoSjI.png)  
&nbsp;
&nbsp;
# LUCROS POR DATAS![](https://i.imgur.com/Qf1jL79.png)
&nbsp;
&nbsp;


# GASTOS FIXOS/TEMPORÁRIOS + BUSCA POR DATAS DOS MESMOS.
![Tela de Lucros](https://i.imgur.com/wALTQem.gif)
&nbsp;
&nbsp;


# MODULO DE ANOTAÇÕES INTEGRADO AO SISTEMA 
![enter image description here](https://i.imgur.com/8GrEuzw.gif)
&nbsp;
&nbsp;


# MODULO DE GARANTIAS CUSTOM/30/60/90 dias.
![enter image description here](https://i.imgur.com/H3EaqIm.gif)
&nbsp;
&nbsp;


# MODULO DE AUTO UPDATE
![enter image description here](https://i.imgur.com/M0oBOTQ.png)
