using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using SimpleInterest;

namespace TestLibrary
{
    public class InterestTest
    {
        [Fact]
        public void InterestTest1person()
        {
            //Arrange
            Person p1 = new Person();//declare objects
            Wallet w1 = new Wallet();
            Card c1 = new Card("Visa", 100);
            Card c2 = new Card("MasterCard", 100);
            Card c3 = new Card("Discover", 100);
            w1.addCard(c1);//create wallet
            w1.addCard(c2);
            w1.addCard(c3);
            p1.addWallet(w1);//assign wallet to person
            interestCalcService interestService = new interestCalcService();

            //Act
            var interest = interestService.calculateInterest(p1);

            //Assert
            Assert.Equal(16, interest);

        }
        [Fact]
        public void InterestTest1card1()
        {
            //Arrange
            Person p1 = new Person();//declare objects
            Wallet w1 = new Wallet();
            Card c1 = new Card("Visa", 100);
            Card c2 = new Card("MasterCard", 100);
            Card c3 = new Card("Discover", 100);
            w1.addCard(c1);//create wallet
            w1.addCard(c2);
            w1.addCard(c3);
            p1.addWallet(w1);//assign wallet to person
            interestCalcService interestService = new interestCalcService();

            //Act
            var wallet = p1.getWallet(0);
            var card = wallet.getCard(0);
            var interest = interestService.calculateInterest(card);

            //Assert
            Assert.Equal(10, interest);
        }
        [Fact]
        public void InterestTest1card2()
        {
            //Arrange
            Person p1 = new Person();//declare objects
            Wallet w1 = new Wallet();
            Card c1 = new Card("Visa", 100);
            Card c2 = new Card("MasterCard", 100);
            Card c3 = new Card("Discover", 100);
            w1.addCard(c1);//create wallet
            w1.addCard(c2);
            w1.addCard(c3);
            p1.addWallet(w1);//assign wallet to person
            interestCalcService interestService = new interestCalcService();

            //Act
            var wallet = p1.getWallet(0);
            var card = wallet.getCard(1);
            var interest = interestService.calculateInterest(card);

            //Assert
            Assert.Equal(5, interest);
        }
        [Fact]
        public void InterestTest1card3()
        {
            //Arrange
            Person p1 = new Person();//declare objects
            Wallet w1 = new Wallet();
            Card c1 = new Card("Visa", 100);
            Card c2 = new Card("MasterCard", 100);
            Card c3 = new Card("Discover", 100);
            w1.addCard(c1);//create wallet
            w1.addCard(c2);
            w1.addCard(c3);
            p1.addWallet(w1);//assign wallet to person
            interestCalcService interestService = new interestCalcService();

            //Act
            var wallet = p1.getWallet(0);
            var card = wallet.getCard(2);
            var interest = interestService.calculateInterest(card);

            //Assert
            Assert.Equal(1, interest);
        }
        [Fact]
        public void InterestTest2person()
        {
            //Arrange
            Person p1 = new Person();//declare objects
            Wallet w1 = new Wallet();
            Wallet w2 = new Wallet();
            Card c1 = new Card("Visa", 100);
            Card c2 = new Card("MasterCard", 100);
            Card c3 = new Card("Discover", 100);
            w1.addCard(c1);//create wallets
            w1.addCard(c3);
            w2.addCard(c2);
            p1.addWallet(w1);//assign wallet to person
            p1.addWallet(w2);
            interestCalcService interestService = new interestCalcService();

            //Act
            var interest = interestService.calculateInterest(p1);

            //Assert
            Assert.Equal(16, interest);
        }
        [Fact]
        public void InterestTest2wallet1()
        {
            //Arrange
            Person p1 = new Person();//declare objects
            Wallet w1 = new Wallet();
            Wallet w2 = new Wallet();
            Card c1 = new Card("Visa", 100);
            Card c2 = new Card("MasterCard", 100);
            Card c3 = new Card("Discover", 100);
            w1.addCard(c1);//create wallets
            w1.addCard(c3);
            w2.addCard(c2);
            p1.addWallet(w1);//assign wallet to person
            p1.addWallet(w2);
            interestCalcService interestService = new interestCalcService();

            //Act
            var wallet = p1.getWallet(0);
            var interest = interestService.calculateInterest(wallet);

            //Assert
            Assert.Equal(11, interest);
        }
        [Fact]
        public void InterestTest2wallet2()
        {
            //Arrange
            Person p1 = new Person();//declare objects
            Wallet w1 = new Wallet();
            Wallet w2 = new Wallet();
            Card c1 = new Card("Visa", 100);
            Card c2 = new Card("MasterCard", 100);
            Card c3 = new Card("Discover", 100);
            w1.addCard(c1);//create wallets
            w1.addCard(c3);
            w2.addCard(c2);
            p1.addWallet(w1);//assign wallet to person
            p1.addWallet(w2);
            interestCalcService interestService = new interestCalcService();

            //Act
            var wallet = p1.getWallet(1);
            var interest = interestService.calculateInterest(wallet);

            //Assert
            Assert.Equal(5, interest);
        }
        [Fact]
        public void InterestTest3person1()
        {
            //Arrange
            Person p1 = new Person();//declare objects
            Person p2 = new Person();
            Wallet w1 = new Wallet();
            Wallet w2 = new Wallet();
            Card c1 = new Card("MasterCard", 100);
            Card c2 = new Card("MasterCard", 100);
            Card c3 = new Card("Visa", 100);
            Card c4 = new Card("Visa", 100);
            Card c5 = new Card("MasterCard", 100);
            w1.addCard(c1);//create wallets
            w1.addCard(c2);
            w1.addCard(c3);
            w2.addCard(c4);
            w2.addCard(c5);
            p1.addWallet(w1);//assign wallet to person
            p2.addWallet(w2);
            interestCalcService interestService = new interestCalcService();

            //Act\
            var interest = interestService.calculateInterest(p1);

            //Assert
            Assert.Equal(20, interest);
        }
        [Fact]
        public void InterestTest3person2()
        {
            //Arrange
            Person p1 = new Person();//declare objects
            Person p2 = new Person();
            Wallet w1 = new Wallet();
            Wallet w2 = new Wallet();
            Card c1 = new Card("MasterCard", 100);
            Card c2 = new Card("MasterCard", 100);
            Card c3 = new Card("Visa", 100);
            Card c4 = new Card("Visa", 100);
            Card c5 = new Card("MasterCard", 100);
            w1.addCard(c1);//create wallets
            w1.addCard(c2);
            w1.addCard(c3);
            w2.addCard(c4);
            w2.addCard(c5);
            p1.addWallet(w1);//assign wallet to person
            p2.addWallet(w2);
            interestCalcService interestService = new interestCalcService();

            //Act\
            var interest = interestService.calculateInterest(p2);

            //Assert
            Assert.Equal(15, interest);
        }
        [Fact]
        public void InterestTest3person1wallet1()
        {
            //Arrange
            Person p1 = new Person();//declare objects
            Person p2 = new Person();
            Wallet w1 = new Wallet();
            Wallet w2 = new Wallet();
            Card c1 = new Card("MasterCard", 100);
            Card c2 = new Card("MasterCard", 100);
            Card c3 = new Card("Visa", 100);
            Card c4 = new Card("Visa", 100);
            Card c5 = new Card("MasterCard", 100);
            w1.addCard(c1);//create wallets
            w1.addCard(c2);
            w1.addCard(c3);
            w2.addCard(c4);
            w2.addCard(c5);
            p1.addWallet(w1);//assign wallet to person
            p2.addWallet(w2);
            interestCalcService interestService = new interestCalcService();

            //Act
            var wallet = p1.getWallet(0);
            var interest = interestService.calculateInterest(wallet);

            //Assert
            Assert.Equal(20, interest);
        }
        [Fact]
        public void InterestTest3person2wallet1()
        {
            //Arrange
            Person p1 = new Person();//declare objects
            Person p2 = new Person();
            Wallet w1 = new Wallet();
            Wallet w2 = new Wallet();
            Card c1 = new Card("MasterCard", 100);
            Card c2 = new Card("MasterCard", 100);
            Card c3 = new Card("Visa", 100);
            Card c4 = new Card("Visa", 100);
            Card c5 = new Card("MasterCard", 100);
            w1.addCard(c1);//create wallets
            w1.addCard(c2);
            w1.addCard(c3);
            w2.addCard(c4);
            w2.addCard(c5);
            p1.addWallet(w1);//assign wallet to person
            p2.addWallet(w2);
            interestCalcService interestService = new interestCalcService();

            //Act\
            var wallet = p2.getWallet(0);
            var interest = interestService.calculateInterest(wallet);

            //Assert
            Assert.Equal(15, interest);
        }
    }
}
