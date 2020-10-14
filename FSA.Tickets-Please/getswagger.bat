cd ..\FSA.IncidentsManagement\
swagger tofile --serializeasv2  --output ..\FSA.Tickets-Please\swagger.json ".\bin\Debug\netcoreapp3.1\FSA.IncidentsManagement.dll"  v1
cd ..\Fsa.Tickets-Please
copy swagger.json ..\ApplicationAssets\swagger.json
