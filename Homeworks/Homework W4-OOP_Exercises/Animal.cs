using System;
namespace Homework_W4_OOP_Exercises
{
	public class Animal
	{
		public string name;
		public string species;
		public string breed;
		public int age;
		public string color;
		public double weight;
		public bool isSpayedorNeutered;

		public Animal(string name, string species, string breed,int age,string color,double weight,bool isSpayedOrNeutered)
		{
			this.name = name;
			this.species = species;
			this.breed = breed;
			this.age = age;
			this.color = color;
			this.weight = weight;
			this.isSpayedorNeutered = isSpayedorNeutered;
		}

		public string GetName()
		{
			return name;
		}
	
		public string GetSpecies()
		{
			return species;
		}

		public string GetBreed()
		{
			return breed;
		}

		public int GetAge()
		{
			return age;
		}

		public string GetColor()
		{
			return color;
		}

		public double GetWeight()
		{
			return weight;
		}

		public bool IsSpayedOrNeutered()
		{

			return isSpayedorNeutered;
		}

		public void SetName(string name)
		{
			this.name = name;
		}

        public void SetSpecies(string species)
		{
			this.species = species;
		}

		public void SetBreed(string breed)
		{
			this.breed = breed;
		}

		public void SetAge(int age)
		{
			this.age = age;
		}

		public void SetColor(string color)
		{
			this.color = color;
		}

		public void SetWeight(double weight)
		{
			this.weight = weight;
		}

		public void SetIsSpayedOrNeutered(bool isSpayedOrNeutered)
		{
			this.isSpayedorNeutered = isSpayedorNeutered;
		}

    }

}

