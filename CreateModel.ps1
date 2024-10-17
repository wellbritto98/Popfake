param (
    [string]$className,
    [string]$properties,
    [string]$insertDto,
    [string]$updateDto,
    [string]$readDto
)

$baseProjectName = "PopFake"
# Caminho da pasta do modelo
$modelsPath = "D:\Projetos\Particular\ASPNet\Popfake\Popfake.Models"
$dtosPath = "D:\Projetos\Particular\ASPNet\Popfake\Popfake.Data\Dtos\$className" + "Dtos"

# Verifica se a pasta existe, se não, cria a pasta
if (-not (Test-Path -Path $modelsPath)) {
    New-Item -ItemType Directory -Path $modelsPath
}

# Define o conteúdo base do arquivo com o namespace e as usings
$fileContent = @"
using PopFake.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace $baseProjectName.Models;

public class $className : BaseEntity 
{
$properties
}
"@

# Nome do arquivo
$fileName = "$modelsPath\$className.cs"

# Cria o arquivo com o conteúdo gerado
New-Item -Path $fileName -ItemType File -Force
Set-Content -Path $fileName -Value $fileContent

Write-Host "Classe $className criada com sucesso em $modelsPath!"

# Verifica se a pasta existe, se não, cria a pasta
if (-not (Test-Path -Path $dtosPath)) {
    New-Item -ItemType Directory -Path $dtosPath
}

# Define o conteúdo base dos arquivos DTO
$insertDtoContent = @"
using System.ComponentModel.DataAnnotations;

namespace $baseProjectName.Data.Dtos;

public class Insert$className" + "Dto : BaseDto
{
    $insertDto
}
"@

$updateDtoContent = @"
using System.ComponentModel.DataAnnotations;

namespace $baseProjectName.Data.Dtos;

public class Update$className" + "Dto : BaseDto
{
    $updateDto
}
"@

$readDtoContent = @"
using System.ComponentModel.DataAnnotations;

namespace $baseProjectName.Data.Dtos;

public class Read$className" + "Dto : BaseDto
{
    $readDto
}
"@

# Nome dos arquivos DTO
$insertDtoFileName = "$dtosPath\Insert$className" + "Dto.cs"
$updateDtoFileName = "$dtosPath\Update$className" + "Dto.cs"
$readDtoFileName = "$dtosPath\Read$className" + "Dto.cs"

# Cria os arquivos DTO com o conteúdo gerado
New-Item -Path $insertDtoFileName -ItemType File -Force
Set-Content -Path $insertDtoFileName -Value $insertDtoContent

New-Item -Path $updateDtoFileName -ItemType File -Force
Set-Content -Path $updateDtoFileName -Value $updateDtoContent

New-Item -Path $readDtoFileName -ItemType File -Force
Set-Content -Path $readDtoFileName -Value $readDtoContent

Write-Host "DTOs criados com sucesso em $dtosPath!"
