### 💡 O que é o Hangfire?

<b>Hangfire</b> é uma biblioteca para .NET (C#) que permite que você <b>execute tarefas em segundo plano (background jobs)</b> de forma fácil e confiável — <b>sem precisar criar Threads, Timers ou Windows Services.</b>

### 🛠️ O que ele faz na prática?

Com o Hangfire, você consegue:

✅ Agendar tarefas para serem executadas <b>depois de um tempo</b>
✅ Rodar tarefas <b>recorrentes</b> (tipo todo dia às 9h)
✅ Executar tarefas <b>assíncronas</b> sem travar sua aplicação
✅ Monitorar o status de execução de cada job por um <b>painel web</b>

### 🖼️ Exemplo de uso:

Você tem um sistema em C# e quer:

- Enviar e-mails em segundo plano
- Processar pedidos demorados sem travar a tela do usuário
- Executar uma tarefa toda madrugada
- Repetir verificações a cada 10 minutos

Em vez de fazer isso manualmente com Thread.Sleep, Task.Delay ou Timer, você usa o Hangfire, que <b>coloca tudo numa fila de jobs</b>, executa com controle, e <b>te dá um painel de monitoramento.</b>

### 📋 Tipos de jobs no Hangfire:

- 🔁 Recurring Job – executa em intervalos definidos (tipo cron)
- ⏳ Delayed Job – executa uma vez depois de um tempo
- ⏱️ Fire-and-forget Job – executa uma vez, imediatamente
- 🧱 Continuations – jobs que rodam depois de outros

### 🖥️ E ele tem painel de controle?

Sim! Ele instala um painel web dentro da sua própria aplicação, onde você pode:

- Ver jobs executados, pendentes, com erro
- Reexecutar falhas
- Ver histórico, logs e muito mais
