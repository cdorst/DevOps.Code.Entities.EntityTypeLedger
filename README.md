# DevOps.Code.Entities.EntityTypeLedger

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-code-entities-entitytypeledger.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/devops-code-entities-entitytypeledger)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Code.Entities.EntityTypeLedger.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.DevOps.Code.Entities.EntityTypeLedger)

## Description

Azure Table Storage entity representing an entity-type

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.Azure.Storage.Metapackage](https://github.com/CDorst/Azure.Storage.Metapackage) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/azure-storage-metapackage.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/azure-storage-metapackage) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Azure.Storage.Metapackage.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Azure.Storage.Metapackage)

## Dependents

The projects below use this repository as a direct dependency.

Name | Status
---- | ------
[DevOps.Code.Entities.EntityTypeLedger.Builder](https://github.com/CDorst/DevOps.Code.Entities.EntityTypeLedger.Builder) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-code-entities-entitytypeledger-builder.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-code-entities-entitytypeledger-builder) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Code.Entities.EntityTypeLedger.Builder.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Code.Entities.EntityTypeLedger.Builder)
[DevOps.Code.Entities.GetEntityTypeRecord](https://github.com/CDorst/DevOps.Code.Entities.GetEntityTypeRecord) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-code-entities-getentitytyperecord.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-code-entities-getentitytyperecord) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Code.Entities.GetEntityTypeRecord.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Code.Entities.GetEntityTypeRecord)

## NuGet


This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.DevOps.Code.Entities.EntityTypeLedger](https://www.nuget.org/packages/CDorst.DevOps.Code.Entities.EntityTypeLedger)

## Version

1.0.5

## Metaproject

DevOps.Code.Entities.EntityTypeLedger is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

