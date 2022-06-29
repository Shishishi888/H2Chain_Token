from aelf import AElf
from google.protobuf.wrappers_pb2 import StringValue
from google.protobuf.wrappers_pb2 import Int64Value


url = 'http://106.3.97.36:8000'
aelf = AElf(url)

genesis_contract_address = aelf.get_genesis_contract_address_string()
contract_address = aelf.get_system_contract_address('AElf.ContractNames.Configuration')

# AElf.ContractNames.Token 换成自己的合约名字
print("contract_address: " + str(contract_address))

private_key = "5b44c12c5ce33b76802b1f5e661f225e08d2e458906e34aca9306129a4a4c117" # 换成自己的私钥


transfer_input_0 = Int64Value()
transfer_input_0.value = 0  # 用C#编写的合约

transfer_input_1 =

transaction = aelf.create_transaction(
     contract_address,
     "DeploySmartContract",
     transfer_input.SerializeToString()
)


print(transaction)
aelf.sign_transaction(private_key, transaction)

result = aelf.execute_transaction(transaction.SerializeToString().hex())

ret = StringValue()
ret.ParseFromString(bytes.fromhex(result.decode()))
print(ret.value)

