# Automação para reescalar os objetivos de otimização do planejamento

### Descrição

Aplicação do tipo _"Plug-in Binary"_ que reescala os objetivos de otimização do planejamento selecionado no TPS _"**Eclipse**"_ para um novo fracionamento de dose.

#

### Temas abordados

-   Desenvolvimento de interface do usuário com diferentes elementos usando _[WPF]( https://learn.microsoft.com/pt-br/dotnet/desktop/wpf/introduction-to-wpf?view=netframeworkdesktop-4.8)_
-   Criação da aparência em _[XAML]( https://learn.microsoft.com/pt-br/dotnet/desktop/wpf/advanced/xaml-in-wpf?view=netframeworkdesktop-4.8)_
-   Adição de elementos na interface gráfica em tempo de execução e criação das operações lógicas usando _[Code-Behind]( https://learn.microsoft.com/pt-br/dotnet/desktop/wpf/advanced/code-behind-and-xaml-in-wpf?view=netframeworkdesktop-4.8)_
-   Manipulação das classes e funcionalidades da **API**, especialmente com aquelas relacionadas aos objetivos de otimização do planejamento

#

### Passo-a-passo da implementação da aplicação

1. Adicionando a interface gráfica do usuário
  
    Criação do layout da interface gráfica do usuário. Para isso vamos adicionar um _[UserControl](  https://learn.microsoft.com/pt-br/dotnet/api/system.windows.controls.usercontrol?view=netframework-4.5)_  ao projeto e incorporar diferentes elementos de controle. Em seguida, vamos conectar a interface à classe inicial do projeto.
     
###

2. Preenchendo os campos da interface gráfica os com dados do fracionamento atual
    
    Criação de um método para obter os valores de dose por fração e número de fração do planejamento atual e preencher os respectivos campos da interface do usuário.

###

3. Preenchendo a interface com os nomes das estruturas que possuem objetivos de otimização
    
     Criação de um método para preencher a interface do usuário com as estruturas que possuem objetivos de otimização.    

###
4. Gerando o manipulador de evento dos campos do novo fracionamento

    Desenvolvimento da lógica do evento de preenchimento dos campos relacionados ao novo fracionamento realizado pelo usuário.
    
###
5. Implementando o manipulador de evento do botão iniciar

     Lógica para duplicar o planejamento selecionado no contexto do Eclipse e atribuir a essa cópia os objetivos de otimização reescalados para o novo fracionamento de dose.

##
### Orientações Finais

- [Download do Visual Studio Community 2019](https://visualstudio.microsoft.com/pt-br/vs/older-downloads/)

| Versão do Eclipse | Versão do .NET Framework |
| ------ | ------ |
| V16+| V 4.6.1 |
| V15.6 ou V15.5 | V 4.5 |
