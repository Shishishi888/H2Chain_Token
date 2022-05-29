package main

import (
	"encoding/hex"
	"fmt"
	"time"

	"github.com/AElfProject/aelf-sdk.go/client"
	proto "github.com/golang/protobuf/proto"
	"github.com/golang/protobuf/ptypes/empty"
	"github.com/golang/protobuf/ptypes/wrappers"
	"google.golang.org/protobuf/types/known/wrapperspb"
)

var aelfClient client.AElfClient
var fromAddress string

func aelfInit(host string, pk string) {
	aelfClient = client.AElfClient{
		Host:       host,
		Version:    "1.0",
		PrivateKey: pk,
	}
	fromAddress = aelfClient.GetAddressFromPrivateKey(aelfClient.PrivateKey)
}

func Initialize() {
	managerListAddr, _ := aelfClient.GetContractAddressByName("AElf.ContractNames.ManagerList")
	empty_buf, _ := proto.Marshal(&empty.Empty{})
	tx, _ := aelfClient.CreateTransaction(fromAddress, managerListAddr, "Initialize", empty_buf)
	signature, _ := aelfClient.SignTransaction(aelfClient.PrivateKey, tx)
	tx.Signature = signature
	transactionByets, _ := proto.Marshal(tx)
	sendResult, _ := aelfClient.SendTransaction(hex.EncodeToString(transactionByets))
	fmt.Println("txID = " + sendResult.TransactionID)
	for {
		res, _ := aelfClient.GetTransactionResult(sendResult.TransactionID)
		if res.Status == "MINED" {
			fmt.Println("Mined.")
			break
		}
		time.Sleep(time.Duration(1) * time.Second)
	}
}

func AddManager(addr string) {
	addr_sv := wrappers.StringValue{
		Value: addr,
	}
	addr_buf, _ := proto.Marshal(&addr_sv)
	managerListAddr, _ := aelfClient.GetContractAddressByName("AElf.ContractNames.ManagerList")
	tx, _ := aelfClient.CreateTransaction(fromAddress, managerListAddr, "AddManager", addr_buf)
	signature, _ := aelfClient.SignTransaction(aelfClient.PrivateKey, tx)
	tx.Signature = signature
	transactionByets, _ := proto.Marshal(tx)
	sendResult, _ := aelfClient.SendTransaction(hex.EncodeToString(transactionByets))
	fmt.Println("txID = " + sendResult.TransactionID)
	for {
		res, _ := aelfClient.GetTransactionResult(sendResult.TransactionID)
		if res.Status == "MINED" {
			fmt.Println("Mined.")
			break
		}
		fmt.Println(res.Status)
		time.Sleep(time.Duration(1) * time.Second)
	}
}

func RemoveManager(addr string) {
	addr_sv := wrappers.StringValue{
		Value: addr,
	}
	addr_buf, _ := proto.Marshal(&addr_sv)
	managerListAddr, _ := aelfClient.GetContractAddressByName("AElf.ContractNames.ManagerList")
	tx, _ := aelfClient.CreateTransaction(fromAddress, managerListAddr, "RemoveManager", addr_buf)
	signature, _ := aelfClient.SignTransaction(aelfClient.PrivateKey, tx)
	tx.Signature = signature
	transactionByets, _ := proto.Marshal(tx)
	sendResult, _ := aelfClient.SendTransaction(hex.EncodeToString(transactionByets))
	fmt.Println("txID = " + sendResult.TransactionID)
	for {
		res, _ := aelfClient.GetTransactionResult(sendResult.TransactionID)
		if res.Status == "MINED" {
			fmt.Println("Mined.")
			break
		}
		fmt.Println(res.Status)
		time.Sleep(time.Duration(1) * time.Second)
	}
}

func CheckManager(addr string) {
	addr_sv := wrappers.StringValue{
		Value: addr,
	}
	addr_buf, _ := proto.Marshal(&addr_sv)
	managerListAddr, _ := aelfClient.GetContractAddressByName("AElf.ContractNames.ManagerList")
	tx, _ := aelfClient.CreateTransaction(fromAddress, managerListAddr, "CheckManager", addr_buf)
	signature, _ := aelfClient.SignTransaction(aelfClient.PrivateKey, tx)
	tx.Signature = signature
	transactionByets, _ := proto.Marshal(tx)

	//注意：View
	sendResult, _ := aelfClient.ExecuteTransaction(hex.EncodeToString(transactionByets))
	res, _ := hex.DecodeString(sendResult)
	realRes := &wrapperspb.BoolValue{}
	proto.Unmarshal(res, realRes)
	fmt.Println(realRes.Value)
}

func main() {
	//第一个参数ip+端口，第二个参数私钥
	aelfInit("http://101.201.46.135:8000", "8e9d0c5741c72690cb0031894cd91bb7278395907d6631a7aa5b86b8beb75585")

	Initialize()

	//下面的都是Address
	CheckManager("2eFQAZk5bYmeBVg1RN7qSAydS1AYyXrSyFVU9BfzBxFZh4csuf")
	AddManager("2eFQAZk5bYmeBVg1RN7qSAydS1AYyXrSyFVU9BfzBxFZh4csuf")
	CheckManager("2eFQAZk5bYmeBVg1RN7qSAydS1AYyXrSyFVU9BfzBxFZh4csuf")
	RemoveManager("2eFQAZk5bYmeBVg1RN7qSAydS1AYyXrSyFVU9BfzBxFZh4csuf")
	CheckManager("2eFQAZk5bYmeBVg1RN7qSAydS1AYyXrSyFVU9BfzBxFZh4csuf")
}
