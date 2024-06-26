




![enter image description here](https://img.shields.io/badge/maintained-yes-brightgreen?style=for-the-badge)

<h2>📢 StandBy System - C#</h2>

**O REPOSITÓRIO PRINCIPAL FOI MOVIDO PARA UM REPOSITÓRIO PRIVADO, MAS MANTEREI ESTE README SEMPRE ATUALIZADO** 

##
### ✅ Sistema de Gerenciamento Integrado para Assistência de Dispositivos Móveis ✅

O sistema oferece um abrangente conjunto de ferramentas para gerenciar faturamento, clientes, dispositivos e serviços específicos para assistências de dispositivos móveis, englobando celulares, tablets, notebooks e outros dispositivos similares.

Desenvolvido sob medida para atender às necessidades específicas dos clientes, o sistema é altamente customizado para proporcionar uma experiência totalmente adaptada. No entanto, é importante observar que caso seja utilizado para outros propósitos ou por diferentes assistências técnicas, podem ser necessários ajustes ou até mesmo modificações substanciais.

Inicialmente criado como um projeto sem fins lucrativos, impulsionado pela busca de experiência e pelo aprimoramento de habilidades, o sistema evoluiu para se tornar uma das soluções mais abrangentes disponíveis para assistências técnicas em geral.

Estamos comprometidos em fornecer uma plataforma robusta e intuitiva, projetada para otimizar os processos de gerenciamento e proporcionar uma experiência excepcional tanto para os clientes quanto para suas respectivas bases de usuários.



## 🛠️ Stack
![enter image description here](https://img.shields.io/badge/Microsoft_SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
![enter image description here](https://img.shields.io/badge/photoshop-%23444444?style=for-the-badge&logo=adobephotoshop)
![enter image description here](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![enter image description here](https://img.shields.io/badge/Express-Express?style=for-the-badge&logoColor=black&label=Dev&labelColor=orange&color=black)
    


## 🍩 Funcionalidades por Módulo  
### ☀️ Módulo de Clientes
#### Funcionalidades:

- Cadastrar Clientes (***Nome, CPF/CNPJ, Nascimento, Sexo, Numero Contato, Numero Recado, Parentesco, Nome Recado, CEP, Rua, Complemento, Bairro, Cidade, Estado***)
- Buscar endereço por CEP (via API)
 - Editar Cliente
 - Remover Cliente
 - Listar Clientes
 - Buscar cliente por Nome
 - **Clientes nao podem ser removidos se existirem serviços vinculados**
---

### ☀️ Módulo de Serviços
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
- Rastreio de peça do serviço
- Uso de peças em estoque para o serviço
- Tela de serviços concluidos
- Garantia
---

### ☀️ Módulo de Lucros/Gastos
#### Funcionalidades:
 - Busca dos lucros entre datas determinadas 
 - Cadastro de gastos com a empresa 
 - Busca de dados por nome/valor
 - Busca de dados entre datas
 - Calculo dos lucros do mes atual automaticamente
---

### ☀️ Módulo de Graficos
#### Funcionalidades:
 - Dados dos lucros semanais
 - Dados dos lucros mensais 
 - Dados dos lucros anuais 
---

### ☀️ Modulo de Anotações
#### Funcionalidades:
 - Inserir anotações
 - Abrir anotações salvas 
 - Salvar anotações 
 - Customização do bloco de notas para atender o cliente. 
---

### ☀️ Modulo de AutoUpdate
#### Funcionalidades:
- Verificação de Versão na nuvem.
- Validação por Hash Code
- Instalação de Certificado
- Automaticamente baixa e instala o sistema.
---

### ☀️ Modulo de Rastreio - Correios
#### Funcionalidades:
 - Cadastrar itens para rastreio
 - Deletar itens de rastreio
 - Listar itens de rastreio
 - Rastreio customizável
 - Rastreio de itens por serviço
---

### ☀️ Modulo de Estoque
#### Funcionalidades:
 - Cadastrar produtos no estoque
 - Editar produtos
 - Remover produtos
 - Lista produtos
 - Edição inline para facilitar o fluxo de trabalho
 - Uso do leitor de codigo de barras
 - Codigo automatico
---

### ☀️ Modulo de PDV
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


### ☀️ Modulo de Licenciamento
#### Funcionalidades:
 - Validação por Hashcode e encryptação MD5, RSA, AES.
 - Verificação de assinatura HMAC
 - Opções de lista negra em várias camadas
 - Ban IP, HWID e Token
 - Webhooks e variáveis server-sided
 - Verificação de licença online e local
 - Compra automatica por pix atraves do software
 - Aplicação automatica da licença


### ☀️ Modulo de Backup Automatico
#### Funcionalidades:
- Efetua o backup do banco automaticamente com tempo de acordo com configuração
- Faz o upload do banco em pasta do GDrive
- Envio de email com status de backup e de serviço para o email cadastrado no sistema
- Gerencia registros necessarios no windows
---
### Algumas imagens não foram atualizadas pois não houveram mudanças significativas no layout ou na funcionalidade
# **🔥 MODULO SERVIÇOS**
<details><summary>SERVIÇOS EM ANDAMENTO</summary>
&nbsp;
&nbsp;

# ![alt text](https://i.imgur.com/pLG7isa.png)
</details>

<details><summary>EDIÇÃO DE SERVIÇOS</summary>
&nbsp;
&nbsp;

# ![alt text](https://i.imgur.com/qp3wTjJ.png)
</details>

<details><summary>TELA DE COMPRAS</summary>
&nbsp;
&nbsp;

# ![alt text](https://i.imgur.com/wpPBQlx.png)
</details>

<details><summary>TELA DE PAGAMENTO</summary>
&nbsp;
&nbsp;

# ![](https://i.imgur.com/yYsmh2o.png)
</details>

<details><summary>O.S - ENTRADA</summary>
&nbsp;
&nbsp;

# ![alt text](https://i.imgur.com/mFA63OK.png)
</details>

<details><summary>IMPRESSÃO O.S - ENTRADA</summary>
&nbsp;
&nbsp;

# ![alt text](https://i.imgur.com/N5YNqEt.png)
</details>

<details><summary>O.S - SAIDA</summary>
&nbsp;
&nbsp;

# ![alt text](https://i.imgur.com/QenA0cG.png)
</details>

<details><summary>IMPRESSÃO O.S - SAIDA</summary>
&nbsp;
&nbsp;

# ![alt text](https://i.imgur.com/n0EE5Ir.png)
</details>

<details><summary>CONFIG - ITEMS DAS COMBOBOX's</summary>
&nbsp;
&nbsp;

# ![alt text](https://i.imgur.com/M5jQYf8.png)
</details>

<details><summary>SERVIÇOS CONCLUÍDOS</summary>
&nbsp;
&nbsp;

# ![alt text](https://i.imgur.com/T7aDMej.png)
</details>






# **🔥 MODULO CLIENTES**
<details><summary>CLIENTES</summary>
&nbsp;
&nbsp;

# ![alt text](https://i.imgur.com/1YEjhWs.png)
</details>

<details><summary>EDIÇÃO DE CLIENTES</summary>
&nbsp;
&nbsp;

# ![alt text](https://i.imgur.com/m2KoefC.png)
</details>



# **🔥 MODULO DE PDV**
<details><summary>PDV (Venda Produtos)</summary>
&nbsp;
&nbsp;

# ![alt text](https://i.imgur.com/U8JRLT2.png)
</details>

<details><summary>LISTAGEM DE VENDAS (CLIENTE > DATA)</summary>
&nbsp;
&nbsp;

# ![alt text](https://i.imgur.com/iZStvEO.png)
</details>




# **🔥 MODULO DE GRÁFICOS**
<details><summary>GRÁFICO SERVIÇOS POR ANO</summary>
&nbsp;
&nbsp;

# ![](https://i.imgur.com/JTb6RN8.png)  
</details>

<details><summary>GRÁFICO SERVIÇOS POR MÊS/SEMANA</summary>
&nbsp;
&nbsp;

# ![](https://i.imgur.com/i1hCjZn.png)  
</details>



# **🔥 MODULO DE RASTREIO**
<details><summary>RASTREIO ENCOMENDAS (Apenas via correios)</summary>
&nbsp;
&nbsp;

# ![](https://i.imgur.com/4xmBZhp.gif)  
</details>

<details><summary>RASTREIO DE COMPRAS PARA SERVIÇO</summary>
&nbsp;
&nbsp;

# ![](https://i.imgur.com/DRqcPRU.gif)  
</details>








# **🔥 MODULO DE LUCROS / GASTOS**
<details><summary>LUCROS POR DATAS / MES ATUAL</summary>
&nbsp;
&nbsp;

![](https://i.imgur.com/HAtIZt5.gif)
</details>

<details><summary>LUCROS COM FILTRO POR MEIO DE PAGAMENTO</summary>
&nbsp;
&nbsp;

![](https://i.imgur.com/50J9K0j.png)
</details>

<details><summary>GASTOS</summary>
&nbsp;
&nbsp;

![](https://i.imgur.com/QXv4ery.png)
</details>

<details><summary>BUSCA POR DATAS</summary>
&nbsp;
&nbsp;

![](https://i.imgur.com/1gkag5l.png)
</details>




# **🔥 MODULO DE GARANTIAS CUSTOM**
<details><summary>REGISTRO GARANTIA</summary>
&nbsp;
&nbsp;

![](https://i.imgur.com/grImqSp.png)
</details>


<details><summary>GARANTIA</summary>
&nbsp;
&nbsp;

![](https://i.imgur.com/Us9wHff.png)
</details>



# **🔥 MODULO LICENÇA**
<details><summary>TELA PRINCIPAL</summary>
&nbsp;
&nbsp;

![](https://i.imgur.com/FpW7D8C.png)
</details>

<details><summary>CARREGANDO LICENÇA</summary>
&nbsp;
&nbsp;

![](https://i.imgur.com/J2YKfRt.png)
</details>

<details><summary>LICENÇA CARREGADA / VALIDADA</summary>
&nbsp;
&nbsp;

![](https://i.imgur.com/Ecj5Q4N.png)
</details>

<details><summary>SOFTWARE ATIVADO</summary>
&nbsp;
&nbsp;

![](https://i.imgur.com/Z6oatPq.png)
</details>












# **🔥 MODULO COMPRA/ATIVAÇÃO AUTOMATICA POR PIX**
<details><summary>COMPRA/ATIVAÇÃO AUTOMATICA POR PIX</summary>
&nbsp;
&nbsp;

![](https://i.imgur.com/takcRau.png)

![](https://i.imgur.com/MbXGtOU.png)

![](https://i.imgur.com/MlmC3Uz.png)
</details>





# **🔥 MODULO DE AUTO UPDATE**
<details><summary>TELA PRINCIPAL</summary>
&nbsp;
&nbsp;

![](https://i.imgur.com/nk8gSz4.png)
</details>




# **🔥 MODULO DE CONFIGURAÇÕES**
<details><summary>CONFIGURAÇÕES</summary>
&nbsp;
&nbsp;

![](https://i.imgur.com/81cKck4.png)
</details>
<details><summary>BANCO DE DADOS</summary>
&nbsp;
&nbsp;

![](https://i.imgur.com/Lje4hu7.png)
</details>
<details><summary>OPÇÕES DE MULTI SELEÇÃO</summary>
&nbsp;
&nbsp;

![](https://i.imgur.com/FNRRQCR.png)
</details>
<details><summary>EMAIL DO SISTEMA</summary>
&nbsp;
&nbsp;

![](https://i.imgur.com/J5mImDt.png)
</details>
<details><summary>REGISTROS DO SISTEMA</summary>
&nbsp;
&nbsp;

![](https://i.imgur.com/0J0nBTI.png)
</details>
<details><summary>EDITOR DE RELATÓRIOS</summary>
&nbsp;
&nbsp;

![](https://i.imgur.com/lZ3aLSD.png)

![](https://i.imgur.com/WqdTQw7.png)
</details>
<details><summary>SERVIÇOS DO WINDOWS</summary>
&nbsp;
&nbsp;

![](https://i.imgur.com/HCk3M2o.png)
=
![](https://i.imgur.com/nZ9E2bI.png)
![](https://i.imgur.com/lh2T2p6.png)
![](https://i.imgur.com/L8ouHWv.png)
![](https://i.imgur.com/4JFnedj.png)
=
![](https://i.imgur.com/dE9AblF.png)
=
![](https://i.imgur.com/xKUpp3s.png)
=
![](https://i.imgur.com/rI1VhQL.png)
=
![](https://i.imgur.com/A7mgQYs.png)

</details>




# **🔥 MODULO DE TEMAS**
<details><summary>CATEGORIAS DE TEMAS</summary>
&nbsp;
&nbsp;

![](https://i.imgur.com/iVkj9Go.png)
</details>
<details><summary>PALETAS DE TEMAS</summary>
&nbsp;
&nbsp;

![](https://i.imgur.com/cfY6V4E.png)
</details>
<details><summary>PREVIEW TEMAS</summary>
&nbsp;
&nbsp;

![](https://i.imgur.com/EHcMnA8.png)
=
![](https://i.imgur.com/dMziOIB.png)
=
![](https://i.imgur.com/r8XF2ZK.png)
=
![](https://i.imgur.com/OqGKbUv.png)
=
![](https://i.imgur.com/8LUqDZ8.png)
=
![](https://i.imgur.com/7vxeYYP.png)
=
![](https://i.imgur.com/pfYEDxL.png)
=
![](https://i.imgur.com/E2rLajK.png)
=
![](https://i.imgur.com/EHcMnA8.png)
=

</details>
