def tribonacci(signature, n):
    print "alex"
    arrayvide=[]
    if n==0:
        return arrayvide
    elif n==1:
        return [signature[0]]
    elif n==2:
        return [signature[0],signature[1]]
    elif n==3:
        return [signature[0],signature[1],signature[2]]
    else:
        for i in range(n-3):
            signature.append(signature[i]+signature[i+1]+signature[i+2])
        return signature
