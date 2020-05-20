# Run SQL
results = run_sql

# Tests
describe :students do
   it "should return 6 students" do
    expect(results.count).to eq 6
   end
end