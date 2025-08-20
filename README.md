# Working with ListView in Reactive MVVM

This example demonstrates how to define listview with reactive MVVM.

## Sample

```xaml
<syncfusion:SfListView x:Name="Articles" BackgroundColor="AliceBlue" ItemSize="60" ItemsSource="{Binding Articles}">
    <syncfusion:SfListView.ItemTemplate>
        <DataTemplate>
            <ViewCell>
                <ViewCell.View>
                    <Grid>
                        <StackLayout Orientation="Vertical">
                            <StackLayout Orientation="Horizontal" Padding="20,10">
                                <Label FontAttributes="Bold" Text="{Binding Title}"
                                        HorizontalOptions="FillAndExpand"/>
                                <Label Text="{Binding Author}" TextColor="Gray"/>
                            </StackLayout>
                            <StackLayout HeightRequest="3" BackgroundColor="DarkSlateGray"/>
                        </StackLayout>
                    </Grid>

                </ViewCell.View>
            </ViewCell>
        </DataTemplate>
    </syncfusion:SfListView.ItemTemplate>
</syncfusion:SfListView>
```

See [Working with ListView in Reactive MVVM](https://www.syncfusion.com/kb/9319/working-with-listview-in-reactive-mvvm)for more details.

## Requirements to run the demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
