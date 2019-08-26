using System;
using Semi;
using Logger = ModTheGungeon.Logger;

namespace SemiModTemplate {
	public class ExampleMod : Mod {
		public Logger Logger = new Logger("ExampleMod");

		public override void Loaded() {
			Logger.Info($"Hello world!");
		}

		public override void RegisterContent() {
			Logger.Debug($"Registering content.");
		}

		public override void InitializeContent() {
			Logger.Debug($"Initializing content.");
		}
	}
}
