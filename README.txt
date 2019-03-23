### Criação Projeto DotNet Core API e Test
dotnet new webapi -n CalcTest.API
dotnet new xunit -o CalcTest.Unit
------------------------------------------------
Docker Toolbox e Heroku - Instalacao/Configuracao

Executar Comandos:
 - Git Bash ( Abrir pelo "Git Bash" o diretorio onde tem o arquivo CalcTest.API.csproj): 
    . dotnet publish -c Release
    . heroku login
	
 - Docker-CLI: 
    . heroku container:login
	. docker build -t calctestapi-dotnet D:/Projeto/CalcTest.API/bin/Release/netcoreapp2.2/publish (Dentro desta pasta tem que ter o arquivo DockerFile)
	. docker tag calctestapi-dotnet registry.heroku.com/calctestapi-dotnet/web
	. docker push registry.heroku.com/calctestapi-dotnet/web
	. heroku container:release web --app calctestapi-dotnet
		
Fontes:
 https://docs.docker.com/toolbox/overview/
 https://docs.microsoft.com/pt-br/dotnet/core/docker/docker-basics-dotnet-core

