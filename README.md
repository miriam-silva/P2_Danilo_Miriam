# 📘 DisciplinasApi – Prova Prática (API REST + Swagger + SQL Server)

Este projeto foi desenvolvido como parte da **Prova Prática** da disciplina de Desenvolvimento de API REST com Swagger + Banco de Dados.  
A API implementa um CRUD completo de disciplinas acadêmicas, documentado com Swagger e persistindo dados em SQL Server.

---

## ✅ Resumo do Projeto
A DisciplinasApi é uma API REST construída em .NET, contendo operações de CRUD para disciplinas. Ela utiliza **Entity Framework Core**, **SQL Server** e **Swagger/OpenAPI** para documentação e testes.

---

# 📂 Requisitos Atendidos

### ✔️ Criar o Projeto (2 pontos)  
Projeto criado com template de API Web no .NET.

### ✔️ Configurar Swagger/OpenAPI (1 ponto)  
Swagger habilitado automaticamente em ambiente de desenvolvimento.  
A entidade **Disciplina** possui:  
- `id` (GUID ou int – chave primária)  
- `nome` (string – obrigatório)  
- `cargaHoraria` (int – obrigatório)  
- `professor` (string – opcional)

### ✔️ Criar Migration (2 pontos)  
Migration criada com **Entity Framework Core** contendo a tabela Disciplinas.

### ✔️ Criar Controller REST (2 pontos)  
Endpoints implementados:  
- `GET /api/disciplinas`  
- `GET /api/disciplinas/{id}`  
- `POST /api/disciplinas`  
- `PUT /api/disciplinas/{id}`  
- `DELETE /api/disciplinas/{id}`  

### ✔️ Persistência no Banco (3 pontos)  
- DbContext criado  
- Migration gerada  
- Banco atualizado com **Update-Database**  
- SQL Server utilizado como persistência  

---
# 🧱 Arquitetura do Projeto
DisciplinasApi/
├── Controllers/
│ └── DisciplinasController.cs
├── Data/
│ └── AppDbContext.cs
├── Models/
│ └── Disciplina.cs
├── Migrations/
├── appsettings.json
└── Program.cs

---

# 🗄️ Modelo da Entidade (Disciplina)

```csharp
public class Disciplina
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int CargaHoraria { get; set; }
    public string? Professor { get; set; }
}

```
# 🛠️ Como Rodar o Projeto
1️⃣ Configure a string de conexão no arquivo appsettings.json
"ConnectionStrings": {
  "ConexaoPadrao": "Server=SEU_SERVIDOR;Database=DisciplinasDb;Trusted_Connection=True;TrustServerCertificate=True;"
}

2️⃣ Criar a Migration
dotnet ef migrations add InitialCreate

3️⃣ Aplicar no banco
dotnet ef database update

4️⃣ Rodar a API
dotnet run


Acesse o Swagger:

👉 http://localhost:5121/swagger

# 📝 Prints solicitados
📌 Print do Swagger Funcionando
<img width="1920" height="1080" alt="Print swagger funcionando" src="https://github.com/user-attachments/assets/67ce7641-c68a-49fb-aaf8-1d2b5a28e614" />

# 📌 Print do dotnet update
<img width="1920" height="1020" alt="print dotnet update visual studio 2022" src="https://github.com/user-attachments/assets/e94d1d37-0936-4a39-a475-6f443ce4d96e" />

# 📌 Print do Banco com dados inseridos
<img width="870" height="912" alt="Print banco de dados" src="https://github.com/user-attachments/assets/fb9f1b09-6bdc-4650-b9f0-343bd21e3d0b" />

# 🧪 Testando os Endpoints

GET → Lista todas as disciplinas

GET /{id} → Retorna uma disciplina específica

POST → Cria uma disciplina

PUT /{id} → Atualiza uma disciplina

DELETE /{id} → Apaga uma disciplina

# 📦 Entrega Final Inclui

✔ Código-fonte da API
✔ Migração criada
✔ Banco atualizado
✔ Prints do Swagger
✔ Prints da Migration
✔ Prints do banco com dados reais
✔ README completo
