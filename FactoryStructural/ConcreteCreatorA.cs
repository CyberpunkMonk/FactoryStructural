using System;

namespace FactoryStructural {
	/// <summary>
	/// A "ConcreteCreator" class
	/// </summary>
	/// <seealso cref="FactoryStructural.Creator" />
	class ConcreteCreatorA:Creator {
		public override Product FactoryMethod() {
			return new ConcreteProductA();
		}
	}
}
