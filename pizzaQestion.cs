Question 1: How to Create the Pizza Ordering Application?
Answer
Open Visual Studio 2019 and create a new Windows Forms App (.NET Framework) project.
Name your project and save it in a folder with your registration number (e.g., 2018ICTXX).
Design the form with the following controls:
GroupBox: For pizza categories (Classic, Signature, etc.) and size (Small, Medium, Large).
ListBox: To display pizza choices.
CheckedListBox: For toppings.
ComboBox: For crust type.
Buttons: For Order and Exit.



private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
{
	// Add pizza categories to the ComboBox
comboBoxCategories.Items.Add("Classic");
comboBoxCategories.Items.Add("Signature");
comboBoxCategories.Items.Add("Favourite");
comboBoxCategories.Items.Add("Supreme");


    // Clear existing items
    listBoxChoices.Items.Clear();

    // Get the selected category
    string selectedCategory = comboBoxCategories.SelectedItem.ToString();

    // Update pizza choices based on the selected category
    if (selectedCategory == "Classic")
    {
        listBoxChoices.Items.Add("Devilled Chicken");
        listBoxChoices.Items.Add("Cheese Lovers");
    }
    else if (selectedCategory == "Signature")
    {
        listBoxChoices.Items.Add("Spicy Veggie");
        listBoxChoices.Items.Add("Black Chicken");
    }
    else if (selectedCategory == "Favourite")
    {
        listBoxChoices.Items.Add("Sri Lankan Spicy");
        listBoxChoices.Items.Add("Butter Cuttlefish");
    }
    else if (selectedCategory == "Supreme")
    {
        listBoxChoices.Items.Add("Chicken Treat");
        listBoxChoices.Items.Add("Garlic Prawns");
    }
}



Question 3: Where Should I Write the UpdateChoices Method?
Answer
Write the UpdateChoices method inside the Form1 class, but outside of any event handlers (like Form1_Load or btnOrder_Click).
Call UpdateChoices() from the CheckedChanged event handlers of your RadioButtons.

private void rbClassic_CheckedChanged(object sender, EventArgs e)
{
    UpdateChoices();
}

private void rbSignature_CheckedChanged(object sender, EventArgs e)
{
    UpdateChoices();
}

// Repeat for other category RadioButtons




Question 4: How to Write the CalculatePrice Method?
Answer
Write the CalculatePrice method to calculate the total price of the order based on size, toppings, and other options.

private double CalculatePrice()
{
    double basePrice = double.Parse(lblPrice.Text);

    // Add extra cost for size
    if (rbMedium.Checked)
    {
        basePrice += basePrice * 0.2; // Add 20% for Medium
    }
    else if (rbLarge.Checked)
    {
        basePrice += basePrice * 0.4; // Add 40% for Large
    }

    // Add Rs. 20 for each selected topping
    for (int i = 0; i < clbToppings.CheckedItems.Count; i++)
    {
        basePrice += 20;
    }

    // Add extra cost for eat options
    if (rbParkAndPick.Checked)
    {
        basePrice += 50;
    }
    else if (rbDeliver.Checked)
    {
        basePrice += 100;
    }

    return basePrice;
}


Question 5: How to Show Order Summary on Clicking Order?
Answer
Write the btnOrder_Click event to show the order summary in a message box.

private void btnOrder_Click(object sender, EventArgs e)
{
    if (lstChoices.SelectedItem == null)
    {
        MessageBox.Show("Please select a pizza choice.");
        return;
    }

    string summary = "You ordered: " + lstChoices.SelectedItem + "\n";

    // Add size
    if (rbSmall.Checked)
    {
        summary += "Size: Small\n";
    }
    else if (rbMedium.Checked)
    {
        summary += "Size: Medium\n";
    }
    else if (rbLarge.Checked)
    {
        summary += "Size: Large\n";
    }

    // Add crust
    summary += "Crust: " + cmbCrustType.SelectedItem + "\n";

    // Add toppings
    string toppings = "";
    for (int i = 0; i < clbToppings.CheckedItems.Count; i++)
    {
        toppings += clbToppings.CheckedItems[i].ToString();
        if (i < clbToppings.CheckedItems.Count - 1)
        {
            toppings += ", ";
        }
    }
    summary += "Toppings: " + (toppings == "" ? "None" : toppings) + "\n";

    // Add eat option
    if (rbParkAndPick.Checked)
    {
        summary += "Eat Option: Park and Pick\n";
    }
    else if (rbDeliver.Checked)
    {
        summary += "Eat Option: Deliver\n";
    }

    // Add total price
    double totalPrice = CalculatePrice();
    summary += "Total Price: Rs. " + totalPrice;

    // Show summary in a message box
    MessageBox.Show(summary, "Order Summary");
}



Question 6: How to Add and Open the "Your Order" Form?
Answer
Add a new form (YourOrderForm) to the project.
Design the form with a RichTextBox (rtbOrderSummary) and a Close Button (btnClose).

public partial class YourOrderForm : Form
{
    public YourOrderForm(string orderSummary)
    {
        InitializeComponent();
        rtbOrderSummary.Text = orderSummary; // Display the order summary
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close(); // Close the form
    }
}


Modify the "Order" button in the main form (Form1) to open the "Your Order" form:
csharp
Copy
Edit


private void btnOrder_Click(object sender, EventArgs e)
{
    if (lstChoices.SelectedItem == null)
    {
        MessageBox.Show("Please select a pizza choice.");
        return;
    }

    string summary = "You ordered: " + lstChoices.SelectedItem + "\n";

    // Add size
    if (rbSmall.Checked)
    {
        summary += "Size: Small\n";
    }
    else if (rbMedium.Checked)
    {
        summary += "Size: Medium\n";
    }
    else if (rbLarge.Checked)
    {
        summary += "Size: Large\n";
    }

    // Add crust
    summary += "Crust: " + cmbCrustType.SelectedItem + "\n";

    // Add toppings
    string toppings = "";
    for (int i = 0; i < clbToppings.CheckedItems.Count; i++)
    {
        toppings += clbToppings.CheckedItems[i].ToString();
        if (i < clbToppings.CheckedItems.Count - 1)
        {
            toppings += ", ";
        }
    }
    summary += "Toppings: " + (toppings == "" ? "None" : toppings) + "\n";

    // Add eat option
    if (rbParkAndPick.Checked)
    {
        summary += "Eat Option: Park and Pick\n";
    }
    else if (rbDeliver.Checked)
    {
        summary += "Eat Option: Deliver\n";
    }

    // Add total price
    double totalPrice = CalculatePrice();
    summary += "Total Price: Rs. " + totalPrice;

    // Open the Your Order form
    YourOrderForm orderForm = new YourOrderForm(summary);
    orderForm.ShowDialog(); // Show the form
}



In Summary
This step-by-step approach includes:

Setting up your form design.
Writing helper methods like UpdateChoices and CalculatePrice.
Showing the order summary in a message box or the "Your Order" form.



Question 1: Simplifying the Order Summary Code

string summary = "You ordered: " + lstChoices.SelectedItem + "\n" +
                 "Size: " + (rbSmall.Checked ? "Small" : rbMedium.Checked ? "Medium" : "Large") + "\n" +
                 "Crust: " + cmbCrustType.SelectedItem + "\n" +
                 "Toppings: " + string.Join(", ", clbToppings.CheckedItems.Cast<string>()) + "\n" +
                 "Eat Option: " + (rbParkAndPick.Checked ? "Park and Pick" : "Deliver") + "\n" +
                 "Total Price: Rs. " + totalPrice;



Question 2: Using a for Loop Instead of foreach

string toppings = "";
for (int i = 0; i < clbToppings.CheckedItems.Count; i++)
{
    toppings += clbToppings.CheckedItems[i].ToString() + ", ";
}
if (!string.IsNullOrEmpty(toppings))
{
    toppings = toppings.TrimEnd(',', ' '); // Remove the trailing comma and space
}


Question 4: Simplifying the Code

To simplify the code and avoid adding a trailing comma, you can build the toppings string without adding an extra comma:

csharp
Copy
Edit


string toppings = "";
for (int i = 0; i < clbToppings.CheckedItems.Count; i++)
{
    toppings += clbToppings.CheckedItems[i].ToString();
    if (i < clbToppings.CheckedItems.Count - 1)
    {
        toppings += ", "; // Add a comma between toppings
    }
}


Question 5: Where to Place the CalculatePrice Method

The CalculatePrice method should be placed within your form's class but outside of any event handlers. You can then call this method from the btnOrder_Click event handler to calculate the total price when the order button is clicked.

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private double CalculatePrice()
    {
        // Calculation logic here
    }

    private void btnOrder_Click(object sender, EventArgs e)
    {
        double totalPrice = CalculatePrice();
        // Use totalPrice as needed
    }
}


Question 6: Adding and Displaying the "Your Order" Form

To display the "Your Order" form after clicking the order button:

Create the "Your Order" Form:

Add a new Windows Form to your project named YourOrderForm.
Design the form to display the order summary, such as using a Label or TextBox.
Modify the Order Button Click Event:

In your main form, modify the btnOrder_Click event to create an instance of YourOrderForm and display it.

private void btnOrder_Click(object sender, EventArgs e)
{
    // Generate the order summary
    string summary = "Your order details here...";

    // Create and show the YourOrderForm
    YourOrderForm orderForm = new YourOrderForm(summary);
    orderForm.ShowDialog();
}


Pass the Order Summary to the "Your Order" Form:
Modify the constructor of YourOrderForm to accept the order summary and display it.

public partial class YourOrderForm : Form
{
    public YourOrderForm(string orderSummary)
    {
        InitializeComponent();
        lblOrderSummary.Text = orderSummary; // Assuming lblOrderSummary is a Label control
    }
}

Question 7: Accessing Properties in the "Your Order" Form

Ensure that the controls in your "Your Order" form have their Modifiers property set to Public or provide public properties or methods to set their values. This allows you to access and modify these controls from the main form.

Example:

// In YourOrderForm
public void SetOrderSummary(string summary)
{
    lblOrderSummary.Text = summary;
}


Question 9: Opening the "Your Order" Form After Clicking the Order Button

To open the "Your Order" form after clicking the order button:

Ensure that the btnOrder_Click event handler creates an instance of YourOrderForm and calls ShowDialog() to display it.

private void btnOrder_Click(object sender, EventArgs e)
{
    // Generate the order summary
    string summary = "Your order details here...";

    // Create and show the YourOrderForm
    YourOrderForm orderForm = new YourOrderForm(summary);
    orderForm.ShowDialog();
}






string correctUsername = "";
string correctPassword = "";

string enteredUsername = txtusername.Text;
string enteredPassword = txtpassword.Text;

if(enteredPassword==correctPassword && enteredUsername==correctUsername)
{
    MessageBox.Show("success");
    Dashboard dashboard = new Dashboard();
    this.Hide();
    dashboard.Show();
}
else
{
    MessageBox.Show("unsuc");
}


string correcUsername = "";
string correctPassword = "";

string enteredusername = txt.Username.Text;
string enteredPassword = txtPassword.Text;

if(enteredUsername==correcUsername && enteredPassword == correctPassword)
{
    MessageBox.Show("suc");
    Dashboard dashboard = new Dashboard();
    this.Hide();
    dashboard.Show();
}
else
{
    MessageBox.Show("");
}


