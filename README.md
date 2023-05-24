# Projeto: Só Recarga.

Projeto Teste, Protótipo Funcional, Prévia do Trabalho de Conclusão de Curso.

## Padronização para elaboração do projeto:

Para manter a organização e a qualidade do código, é importante seguir os seguintes passos ao iniciar uma etapa:

1. Atualize a lista de referências remotas no repositório local com o comando Git Fetch:

```git
git pull
```

2. Criar uma Branch para a implementação:

```git
git checkout -b nome-da-branch
```

3. Realizar toda a implementação na Branch criada:

```git
git add .
git commit -m "Descrição das alterações realizadas"
```

4. Após a finalização, realizar um Pull Request para que o código gerado seja revisado:

```git
# Subir as alterações da branch para o repositório remoto
git push origin nome-da-branch
```

Em seguida, na plataforma de hospedagem do repositório, crie um Pull Request da Branch criada para a Branch Main.

5. Se estiver tudo certo, realizar o Merge para a Branch Main:

```git
# Voltar para a branch main
git checkout main
```

6. Manter o projeto sempre funcional e limpo.

Caso tenha dúvidas ou não esteja familiarizado com esse fluxo de trabalho, recomendamos assistir ao seguinte conteúdo: [RocketSeat](https://app.rocketseat.com.br/discover/course/github-para-times).

Em caso de dúvidas, entre em contato pelo Whatsapp ou Discord.

## Padronização da documentação:

Para manter um registro claro e organizado de todas as implementações realizadas no projeto, é importante que cada mudança seja anotada e explicada em um arquivo dentro da pasta "Documentation".

Sugerimos o seguinte padrão de nomenclatura para os arquivos: YYYY-MM-DD-descricao-das-alteracoes.txt, onde "YYYY-MM-DD" representa a data em que a alteração foi realizada e "descricao-das-alteracoes" é uma breve descrição do que foi implementado. Utilize letras minúsculas e hífen (-) para separar as palavras.

Além disso, recomendamos que as anotações de implementação sejam salvas em arquivos de texto simples com a extensão ".txt", já que esse é um formato amplamente utilizado e que pode ser aberto em praticamente qualquer editor de texto.

Ao finalizar cada implementação, o desenvolvedor responsável deve criar um arquivo de texto dentro da pasta "Documentation" com uma descrição detalhada das alterações realizadas. Esse arquivo deve incluir o nome do desenvolvedor, a data da implementação e as modificações feitas no código.

Essas informações serão usadas posteriormente para a criação da documentação final do trabalho, o que tornará o processo de documentação mais fácil e organizado. Lembrando que essa prática é importante para manter a transparência e a colaboração no desenvolvimento do projeto, além de facilitar a identificação e correção de eventuais erros ou bugs.

## Por que usar a estrutura de microserviços?

A estrutura de microserviços é uma abordagem de arquitetura de software em que uma aplicação é dividida em pequenos serviços independentes que trabalham juntos para fornecer as funcionalidades necessárias.

Cada microserviço é altamente especializado e pode ser desenvolvido, implantado e escalado independentemente dos outros, o que traz muitas vantagens em termos de flexibilidade, resiliência, escalabilidade e facilidade de manutenção.
