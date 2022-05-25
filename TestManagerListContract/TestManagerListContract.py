from aelf import AElf
from aelf import Address
from google.protobuf.empty_pb2 import Empty
from google.protobuf.wrappers_pb2 import StringValue


url = 'http://127.0.0.1:8000'
aelf = AElf(url)

genesis_contract_address = aelf.get_genesis_contract_address_string()
contract_address = aelf.get_system_contract_address('AElf.ContractNames.ManagerList')

# AElf.ContractNames.Token 换成自己的合约名字
print("contract_address: " + str(contract_address))

private_key = "5b44c12c5ce33b76802b1f5e661f225e08d2e458906e34aca9306129a4a4c117" # 换成自己的私钥


# transfer_input = Empty()
#
# transaction = aelf.create_transaction(
#      contract_address,
#      "Initialize",
#      transfer_input.SerializeToString()
# )

transfer_input = StringValue()
transfer_input.value = "y35saYSrfXtQXKWodZ2XEBA2wCdbC21YKzFHxwLhZovgsX4xn"

transaction = aelf.create_transaction(
     contract_address,
     "AddManager",
     transfer_input.SerializeToString()
)

aelf.sign_transaction(private_key, transaction)


result = aelf.execute_transaction(transaction.SerializeToString().hex())

# ret = StringValue()
# ret.ParseFromString(bytes.fromhex(result.decode()))
# print(ret.value)

print(result)
