
using _02_Interface;

IDataProcess dataProcess = new MyData();
dataProcess.ProcessData(new DBData());
dataProcess.ProcessData(new FileData());