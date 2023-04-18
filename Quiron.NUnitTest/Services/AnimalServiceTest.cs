﻿using AutoMapper;
using Moq;
using NUnit.Framework;
using Quiron.Domain.Dto;
using Quiron.Domain.Entities;
using Quiron.Domain.Interfaces.Data;
using Quiron.Domain.Interfaces.Services;
using Quiron.NUnitTest.Utilitarios;
using Quiron.Service.Services;

namespace Quiron.NUnitTest.Services
{
    public class AnimalServiceTest
    {
        private IMapper _mapper;
        private IAnimalService _animalService;
        private Mock<IAnimalRepository> _animalRepository;

        public AnimalServiceTest()
        {
            _mapper = Mapeador.GetMapper();
            _animalRepository = new Mock<IAnimalRepository>();
            _animalService = new AnimalService(_mapper, _animalRepository.Object);
        }

        [Test]
        public void CriarTest()
        {
            AnimalDto animal = new AnimalDto();
            Assert.DoesNotThrow(() => _animalService.Criar(animal));
        }

        [Test]
        public void AtualizarTest()
        {
            AnimalDto animal = new AnimalDto();
            Assert.DoesNotThrow(() => _animalService.Atualizar(animal));
        }

        [Test]
        public void RemoverTest()
        {
            AnimalDto animal = new AnimalDto();
            Assert.DoesNotThrow(() => _animalService.Remover(animal));
        }

        [Test]
        public void ObterTodosTest()
        {
            Animal animal01 = new Animal(Guid.NewGuid(), "Peixe");
            Animal animal02 = new Animal(Guid.NewGuid(), "Urso");

            IList<Animal> animais = new List<Animal>();
            animais.Add(animal01);
            animais.Add(animal02);

            _animalRepository.Setup(r => r.ObterTodos()).Returns(animais.AsQueryable());
            Assert.IsNotNull(_animalService.ObterTodos());
        }

        [Test]
        public void PesquisarPorIdTest()
        {
            Animal animal = new Animal(Guid.NewGuid(), "Coelho");

            _animalRepository.Setup(r => r.PesquisarPorId(animal.Id)).Returns(animal);
            Assert.IsNotNull(_animalService.PesquisarPorId(animal.Id));
        }
    }
}