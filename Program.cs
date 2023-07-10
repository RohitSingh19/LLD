﻿
using LLD.DesignPatterns.Builder;
using LLD.DesignPatterns.Factory;
using LLD.DesignPatterns.Prototype;
using LLD.DesignPatterns.Template;
using LLD.OOP;

public class Program
{
    public static void Main(string[] args)
    {
        //EncapsulationExample eg = new EncapsulationExample();
        //eg.Run();

        //InheritanceExample example = new InheritanceExample();
        //example.Run();
        //inhertiance inhertiance = new inhertiance();
        //inhertiance.Function();

        //AssociationExample example = new AssociationExample();
        //example.RunAssociationExample();


        //DocumentEngine documentEngine = new DocumentEngine();
        //documentEngine.RunDocumentEngine();

        //DocumentGeneratorClient documentGeneratorClient = new DocumentGeneratorClient();
        //documentGeneratorClient.RunDocumentEngine();

        //PrototypeRunner runner = new PrototypeRunner();
        //runner.protoTypeRunnerMethod();

        FactoryRunner factoryRunner = new FactoryRunner();
        factoryRunner.FactoryRunnerMethod();

    }
}