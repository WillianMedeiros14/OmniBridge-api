## OmniBridge 🚀

### Contexto

Esse projeto baseado em microsserviços oferece uma excelente oportunidade para o aprendizado de arquitetura distribuída. Com dois serviços independentes, exploram conceitos fundamentais de design de APIs e manipulação de banco de dados.Promovendo a compreensão das melhores práticas em desenvolvimento de software, como desacoplamento, escalabilidade e uso de Docker para conteinerização. Apesar de ser uma solução simples, prepara o terreno para desafios mais complexos em projetos de larga escala, distribuindo a responsabilidade dos serviços de forma organizada e eficiente.

### Atividade

Esta solução consiste em dois microsserviços:

- Microsserviço principal (omniBridge-service)
- Microsserviço de criação de conta (omniBridge-microservices-register)

### Funcionalidades

Microsserviço principal:

- Login.

Microsserviço de criação de conta:

- Criação de conta de usuário;
- Buscar endereço pelo cep.

## Tecnologias Utilizadas 🛠️

As principais tecnologias e bibliotecas utilizadas no projeto incluem:

- **.NET Core 8.0**
- **PostgreSQL**
- **Swagger**
- **Docker e Docker Compose**
- **API do serviço https://viacep.com.br/.**

---

## Configuração do Ambiente ⚙️

1. Clone o repositório e entre na pasta:

   ```bash
   git clone https://github.com/WillianMedeiros14/OmniBridge-api
   cd OmniBridge-api
   ```

---

## Rodando a Aplicação ▶️

- Esteja na raiz do projeto e rode o comando abaixo:

  ```bash
  docker compose up
  ```

- obs: todos os serviços precisam estar rodando para a aplicação funcionar normalmente

## Acesso as aplicações

Depois de rodar as aplicações, elas estarão disponíveis em:

- Microsserviço de criação de conta (omniBridge-microservices-register): http://localhost:8081/swagger/index.html
- Microsserviço principal (omniBridge-service): http://localhost:8082/swagger/index.html

🚀 Caso queira uma experiencia melhor, foi construída um aplicação em flutter para usar esta api, ela pode ser encontrada no link abaixo:

```bash
 https://github.com/WillianMedeiros14/omnibridgea_app
```

- Você pode assistir ao vídeo do resultado do projeto [aqui](https://drive.google.com/file/d/11ScBXUUZGwf9e2w90bidQDYE5fLujmqo/view?usp=sharing).
