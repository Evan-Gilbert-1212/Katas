results = run_sql

describe :countries do
   it "should return 3 capitals" do
    expect(results.count).to eq 3
   end
end