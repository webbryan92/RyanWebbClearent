using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterest
{
    public class Card
    {
        private string cardBrand;
        private int value;
        private double rate = 0;

        public Card(string brand, int amount)
        {
            cardBrand = brand;
            value = amount;
        }
        public double getRate()
        {
            if (cardBrand == "Visa")
            {
                rate = .1;
            }
            else if (cardBrand == "MasterCard")
            {
                rate = .05;
            }
            else if (cardBrand == "Discover")
            {
                rate = .01;
            }
            return rate;
        }
        public int getAmount()
        {
            return value;
        }
    }
    public class Wallet
    {
        private List<Card> cards= new List<Card>();
        public Wallet()
        {            
        }
        public void addCard(Card card)
        {
            cards.Add(card);
        }
        public Card getCard(int index)
        {
            return cards[index];
        }
        public List<Card> getAllCards()
        {
            return cards;
        }
        public int cardCount()
        {
            return cards.Count();
        }
    }
    public class Person
    {
        private List<Wallet> wallets = new List<Wallet>();
        public Person()
        {
        }
        public void addWallet(Wallet wallet)
        {
            wallets.Add(wallet);
        }
        public Wallet getWallet(int index)
        {
            Wallet tempwallet = wallets[index];
            return tempwallet;
        }
        public List<Wallet> getAllWallets()
        {
            return wallets;
        }
        public int walletCount()
        {
            return wallets.Count();
        }
    }
    public class interestCalcService
    {
        public interestCalcService()
        {
        }
        public int calculateInterest(Person person)
        {
            List<Wallet> wallets = person.getAllWallets();
            int totalInterest = 0;
            foreach (var wallet in wallets)
            {
                totalInterest += calculateInterest(wallet);
            }
            return totalInterest;
        }
        public int calculateInterest(Wallet wallet)
        {
            List<Card> cards = wallet.getAllCards();
            int totalInterest = 0;
            foreach (var card in cards)
            {
                totalInterest += calculateInterest(card);
            }
            return totalInterest;
        }
        public int calculateInterest(Card card)
        {
            int interest = 0;
            interest += Convert.ToInt32(card.getAmount() * card.getRate());
            return interest;
        }
    }
}
