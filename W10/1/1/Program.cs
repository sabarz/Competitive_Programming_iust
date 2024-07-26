ir<int,int> num[1001000];
long long s1[1001000],s2[1001000],ans=0;
int main()
{
    int n;
    cin >> n;
    for(int i = 0 ;i < n;i++)
    {
        cin >> num[i].first;
        num[i].second = i+1;
    }
    sort(num,num+n);
    for(int i = n-1 ; i >=0; i--)
    {
        int big = 0;
        for(int j = num[i].second -1; j ; j -=(j&(-j)))
        {
            big += s1[j];
            ans += s2[j];
        }
        for(int j = num[i].second ;j<1001000; j +=(j&(-j)))
        {
                s1[j]++;
                s2[j] += big;
        }
    }
    cout << ans << endl;
    return 0