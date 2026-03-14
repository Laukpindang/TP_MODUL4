using TP_MODUL4_103022400053;

Console.WriteLine("Batununggal: " + KodePos.getKodePos("Batununggal"));

DoorMachine doorMachine = new DoorMachine();
Console.WriteLine("Trigger: BukaPintu");
doorMachine.UbahState(DoorMachine.Trigger.BukaPintu);
Console.WriteLine("Trigger: KunciPintu");
doorMachine.UbahState(DoorMachine.Trigger.KunciPintu);
