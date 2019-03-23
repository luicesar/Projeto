### Criação Projeto DotNet Core API e Test
dotnet new webapi -n CalcTest.API
dotnet new xunit -o CalcTest.Unit
------------------------------------------------
Docker Toolbox e Heroku - Instalacao/Configuracao

Executar Comandos:
 1. Git Bash ( Abrir pelo "Git Bash" o diretorio onde tem o arquivo CalcTest.API.csproj): 
    1.1 dotnet publish -c Release
    1.2 heroku login
	
 2. Docker-CLI: 
    2.1 heroku container:login
	2.2 docker build -t calctestapi-dotnet D:/Projeto/CalcTest.API/bin/Release/netcoreapp2.2/publish (Dentro desta pasta tem que ter o arquivo DockerFile)
	2.3 docker tag calctestapi-dotnet registry.heroku.com/calctestapi-dotnet/web
	2.4 docker push registry.heroku.com/calctestapi-dotnet/web
	2.5 heroku container:release web --app calctestapi-dotnet

Obs: Para atualizar minhas images:
    . docker images (visualizar as imagens)
    . docker rmi --force 'image id'
    . refazer o item 1.1, 2.2 até 2.5
		
Fontes:
 https://docs.docker.com/toolbox/overview/
 https://docs.microsoft.com/pt-br/dotnet/core/docker/docker-basics-dotnet-core

