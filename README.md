# Ninja_Academy

### Link do itch.io:
https://andresabcb.itch.io/ninja-academy

## A ideia do jogo
Os ninjas surgiram na necessidade de terem agentes secretos durante o Japão Feudal. Eles tinham como função combater seus inimigos de maneira secreta.
No nosso jogo, queremos abordar a história e os fundamentos ninjas.
Idealmente, implementaríamos as fases de acordo com as habilidades exigidas por cada um dos ranks de ninjas.
Implementamos duas etapas do primeiro rank (Academy Student), que é o inicial para os ninjas. Essencialmente, teríamos: Academy Student, Genin, Chunin, Jonin e Kage.

Seguem as explicações sobre cada um desses ranks de Ninjas:

**1) Academy Student:** são o corpo estudantil da Academia, são ensinados sobre as técnicas básicas sobre o mundo ninja. Quando se formarem serão promovidos a Genin e se juntarão à força ninja.

**2) Genin:** são o rank mais baixo dentre os ninjas "de verdade" e desafiam quaisquer outros ninjas.

**3) Chunin:** são antigos Genin que foram promovidos pelas excelentes estratégias e habilidades de combate. São equivalentes a capitães militares.

**4) Jonin:** ninjas muito experientes e habilidosos, são altamente respeitados.

**5) Kage:** são os ninjas mais fortes no seu vilarejo escondido. Servem de pilar para todas as pessoas envolvidas naquele vilarejo.

## O storytelling
Nosso personagem principal é o Ninja Frog. Ele é um aspirante a se tornar um Ninja muito experiente.
No estágio implementado, nosso protagonista está aprendendo o básico dos fundamentos Ninja.

Isso implica em saber:
- pular
- desviar de obstáculos
- identificar perigos

## Descrição oficial
Os ninjas surgiram na necessidade de terem agentes secretos durante o Japão Feudal. Eles tinham como função combater seus inimigos de maneira secreta.

E assim, o Ninja Frog sempre sonhou em se tornar um Kage - o nível mais alto dos ninjas. Para isso, ele tem que passar por todas as etapas do treinamento.

O ajude a conquistar novas habilidades e se formar na Academy Student - a etapa inicial do treinamento.

## How to play
Aperte o espaço para pular e as setinhas (direita e esquerda) para se mover para os lados.

Simples assim.

Mas cuidado! Nem todos os terrenos são seguros...

## Beat Chart
Fase 1 - nessa fase, o jogador aprende a pular e a chegar ao final do jogo.
Fase 2 - aqui, o jogador vai aprender que existem terrenos que são perigosos e que o fazem voltar para o início 
Fase 3 - e nessa fase, nosso ninja aprende que nem todos os caminhos óbvios são os melhores (se ele seguir todos não vai conseguir chegar na bandeira).

## Aprendizados
Ao longo desse projeto, iteramos e pivotamos diversas vezes o que tínhamos como "certeza" antes. 
A ideia inicial era usarmos ferramentas para fazermos o nosso jogador atravessar os obstáculos e chegar no final.
Ao longo do processo, entendemos que não seria tão legal ter poucas opções de ferramentas, e que focar nos obstáculos
e nos mapas de cada nível poderia ter um melhor resultado (pensando na complexidade esperada do projeto).

Além disso, pudemos entender mais sobre como a experiência do usuário deve ser formada.
É muito importante aumentar gradativamente as diferenças entre fases, porque isso pode confundir o usuário 
(exemplo: mudança brusca de cenário, muitas novas funcionalidades e muitos mecanismos introduzidos de uma vez).
Lembrando sempre que a melhor User Experience é aquela que é imperceptível.
Para isso, passamos bastante tempo testando o jogo (nós mesmos) até chegarmos em uma versão incial, que foi para o Playtest.
No Playtest, descobrimos que algumas das nossas prioridades antigas não eram realmente prioridades, 
e descobrimos também alguns pontos de melhoria que não tínhamos pensado antes.

Nesse projeto, apenas a visão técnica não era suficiente, precisamos entender cada detalhe nas entrelinhas da nossa criação
(e entender muito bem o nosso público para criarmos algo que o impacte e empolgue de verdade).

## Melhorias
Tendo mais tempo com esse projeto, gostaríamos de continuar implementando as fases e novos features e ferramentas para ajudar o nosso Ninja Frog
a conquistar o seu título de Kage.
Algumas ideias que tivemos seriam:
- adicionar como obstáculos objetos cortantes ninjas animados na cena, para que o ninja tenha que desviar enquanto faz o seu caminho ideal
- implementar blocos de apoio que desmoronam, para que ele tenha que pensar rápido
- usar como ferramenta uma mola que dá um maior impulso para pular

Poderíamos também criar os nossos próprios assets, que demanda bastante tempo.

## Conclusão
Foi muito interessante poder desenvolver um projeto e já ter um retorno gráfico do que estávamos fazendo, principalmente por ser tão dinâmico.
Esperamos que para os próximos projetos possamos usar o que já aprendemos nesse e que possamos nos desenvolver mais ainda.
Agradecemos toda a ajuda que sempre disponibilizam para nós!
Esperamos também que tenham gostado do nosso projeto! :)

Por Andresa Bicudo e Guilherme Carvalho


## Referências
Start menu
- https://www.youtube.com/watch?v=zc8ac_qUXQY

A estrutura dos níveis
- https://www.youtube.com/watch?v=Vt7VtkWb3R4&list=PLW-9djkTMdfVNJD9aEnoOzkrU8dUoD7j4&index=1

Acionar a cena de vitória/próxima cena
- https://www.youtube.com/watch?v=Bc9lmHjqLZc 
- https://www.youtube.com/watch?v=KA6g0ULzLvY&list=PLW-9djkTMdfVNJD9aEnoOzkrU8dUoD7j4&index=13

Mudar a fonte
- https://docs.unity3d.com/560/Documentation/Manual/class-Font.html#:~:text=To%20add%20a%20font%20to,files)%20and%20OpenType%20Fonts%20
