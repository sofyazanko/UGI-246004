using System;
using NUnit.Framework;
using MilitaryLibrary;

namespace MilitaryLibrary.UnitTests
{
    [TestFixture]
    public class ServicemanUnitTests
    {
        [Test]
        public void ConstructorTest()//тест конструктора
        {
            var soldier = CreateTestServiceman();
            Assert.That(soldier.Name, Is.EqualTo("Иван"));
            Assert.That(soldier.Surname, Is.EqualTo("Петров"));
            Assert.That(soldier.MilitaryIDN, Is.EqualTo("АБВ123456"));
            Assert.That(soldier.Type, Is.EqualTo(TypeService.Urgent));
        }

        [Test]
        public void GetInfoTest()
        {
            var soldier = CreateTestServiceman();//создаем тестового военнослуж
            soldier.Rank = "Сержант";
            soldier.MilUnitNumber = "54321";
            soldier.EnlistmentDate = new DateTime(2020, 5, 25);

            var info = soldier.GetInfo();
            Assert.That(info.Length, Is.EqualTo(2));
            Assert.That(info[0], Is.EqualTo("Иван Петров"));
            Assert.That(info[1], Is.EqualTo($"Военный билет: АБВ123456. Звание: Сержант. Часть: 54321. Поступил: 25.05.2020. Срок службы: {DateTime.Now.Year - 2020} лет. Тип службы: срочная."));
        }

        private Serviceman CreateTestServiceman()
        {
            return new Serviceman("Иван", "Петров", "АБВ123456", TypeService.Urgent);
        }
    }
}