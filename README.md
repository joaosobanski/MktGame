
# Criar projeto console

dotnet new console -n Teste

# Criar projeto Nunit

dotnet new nunit -n TestUnit

# Criar projeto Funcao

dotnet new classlib -n Funcao



# Adicionar sln
dotnet sln MktGame.sln add ./Funcao/Funcao.csproj

# Adicionar dependencia de projeto
cd TestUnit 
dotnet add ../Funcao/Funcao.csproj

# Adicionar dependencias Guard FluentTest
cd Funcao
dotnet add package Microsoft.Toolkit.Diagnostics
cd TestUnit
dotnet add package FluentAssertions

